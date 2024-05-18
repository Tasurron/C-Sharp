using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogReg
{
    public partial class CURD : Form
    {
        public CURD()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T3FKTDS\SQLEXPRESS;Initial Catalog=players;Integrated Security=True;");
        public int InventorySI;
        private void CURD_Load(object sender, EventArgs e)
        {
            GetInventoryRecord();
        }

        private void GetInventoryRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from InventoryTbl", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            InventoryRecordDataGridView.DataSource = dt;
            InventoryRecordDataGridView.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into InventoryTbl (ProductId, ProductName, UnitAvailable, UnitPrice) values (@id, @name, @unitAvailable, @unitPrice)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", p_id.Text);
                cmd.Parameters.AddWithValue("@name", p_name.Text);
                cmd.Parameters.AddWithValue("@unitAvailable", u_available.Text);
                cmd.Parameters.AddWithValue("@unitPrice", u_price.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetInventoryRecord();
                ResetFormControls();

            }
        }

        private bool IsValid()
        {
            if (p_id.Text == string.Empty)
            {
                MessageBox.Show("Inter Product id to Insert", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            InventorySI = 0;
            p_id.Clear();
            p_name.Clear();
            u_available.Clear();
            u_price.Clear();

            p_id.Focus();
        }

        private void InventoryRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InventorySI = Convert.ToInt32(InventoryRecordDataGridView.SelectedRows[0].Cells[0].Value);
            p_id.Text = InventoryRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            p_name.Text = InventoryRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            u_available.Text = InventoryRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            u_price.Text = InventoryRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InventorySI > 0)
            {
                SqlCommand cmd = new SqlCommand("update InventoryTbl set ProductId = @id, ProductName = @name, UnitAvailable = @unitAvailable, UnitPrice = @unitPrice where InventorySI = @SI", con); // Changed @Sl to @SI
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", p_id.Text);
                cmd.Parameters.AddWithValue("@name", p_name.Text);
                cmd.Parameters.AddWithValue("@unitAvailable", u_available.Text);
                cmd.Parameters.AddWithValue("@unitPrice", u_price.Text);
                cmd.Parameters.AddWithValue("@SI", this.InventorySI);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product information is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetInventoryRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a product to update information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InventorySI > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from InventoryTbl where InventorySI = @SI", con); // Changed from @Sl to @SI
                cmd.Parameters.AddWithValue("@SI", this.InventorySI);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product is deleted form inventory", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetInventoryRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a product to delete", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void InventoryRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
