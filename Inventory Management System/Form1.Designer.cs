namespace LogReg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            check_pass = new CheckBox();
            con_password = new TextBox();
            label9 = new Label();
            password = new TextBox();
            label8 = new Label();
            address = new TextBox();
            label7 = new Label();
            email = new TextBox();
            label6 = new Label();
            gender = new ComboBox();
            date = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            last_name = new TextBox();
            label3 = new Label();
            first_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(check_pass);
            panel1.Controls.Add(con_password);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(address);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(date);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(last_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(first_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(181, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 494);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(357, 450);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 20);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(210, 400);
            button1.Name = "button1";
            button1.Size = new Size(210, 47);
            button1.TabIndex = 20;
            button1.Text = "Sign Up";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // check_pass
            // 
            check_pass.AutoSize = true;
            check_pass.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_pass.Location = new Point(377, 354);
            check_pass.Name = "check_pass";
            check_pass.Size = new Size(121, 21);
            check_pass.TabIndex = 19;
            check_pass.Text = "Show Password";
            check_pass.UseVisualStyleBackColor = true;
            check_pass.CheckedChanged += check_pass_CheckedChanged;
            // 
            // con_password
            // 
            con_password.Location = new Point(377, 321);
            con_password.Name = "con_password";
            con_password.Size = new Size(211, 27);
            con_password.TabIndex = 18;
            con_password.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(377, 298);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 17;
            label9.Text = "Confirm Password";
            // 
            // password
            // 
            password.Location = new Point(377, 245);
            password.Name = "password";
            password.Size = new Size(211, 27);
            password.TabIndex = 16;
            password.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 222);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 15;
            label8.Text = "Password";
            // 
            // address
            // 
            address.Location = new Point(374, 174);
            address.Name = "address";
            address.Size = new Size(211, 27);
            address.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 151);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 13;
            label7.Text = "Address";
            // 
            // email
            // 
            email.Location = new Point(374, 106);
            email.Name = "email";
            email.Size = new Size(211, 27);
            email.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 83);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(56, 320);
            gender.Name = "gender";
            gender.Size = new Size(211, 28);
            gender.TabIndex = 10;
            // 
            // date
            // 
            date.Location = new Point(56, 245);
            date.Name = "date";
            date.Size = new Size(211, 27);
            date.TabIndex = 9;
            date.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 297);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 222);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 5;
            label4.Text = "Birth Date";
            // 
            // last_name
            // 
            last_name.Location = new Point(53, 174);
            last_name.Name = "last_name";
            last_name.Size = new Size(211, 27);
            last_name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // first_name
            // 
            first_name.Location = new Point(53, 106);
            first_name.Name = "first_name";
            first_name.Size = new Size(211, 27);
            first_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 83);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(229, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 43);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox last_name;
        private Label label3;
        private TextBox first_name;
        private ComboBox gender;
        private DateTimePicker date;
        private TextBox email;
        private Label label6;
        private TextBox con_password;
        private Label label9;
        private TextBox password;
        private Label label8;
        private TextBox address;
        private Label label7;
        private CheckBox check_pass;
        private Button button1;
        private LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
