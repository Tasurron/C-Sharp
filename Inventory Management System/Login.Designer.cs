namespace LogReg
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            password = new TextBox();
            label3 = new Label();
            user_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(211, 38);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(user_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(228, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 416);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 125);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 25;
            label4.Text = "Username (Email)";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(314, 359);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(155, 309);
            button1.Name = "button1";
            button1.Size = new Size(210, 47);
            button1.TabIndex = 22;
            button1.Text = "Sign In";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(155, 250);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 21);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // password
            // 
            password.Location = new Point(155, 217);
            password.Name = "password";
            password.Size = new Size(236, 27);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 194);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // user_name
            // 
            user_name.Location = new Point(155, 148);
            user_name.Name = "user_name";
            user_name.Size = new Size(236, 27);
            user_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 24;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox user_name;
        private Label label2;
        private TextBox password;
        private Label label3;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label4;
    }
}