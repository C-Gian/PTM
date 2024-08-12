namespace Personal_Task_Manager.Views.LoginForm
{
    partial class LoginView
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
            header = new Label();
            label2 = new Label();
            txt_password = new MaskedTextBox();
            txt_email = new TextBox();
            error_label = new Label();
            btn_cancel = new Button();
            btn_login = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            signup_label = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top;
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(203, 41);
            header.Name = "header";
            header.Size = new Size(160, 65);
            header.TabIndex = 1;
            header.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_password.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(12, 262);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(534, 39);
            txt_password.TabIndex = 3;
            txt_password.MaskInputRejected += txt_password_MaskInputRejected;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(12, 168);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(534, 39);
            txt_email.TabIndex = 4;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // error_label
            // 
            error_label.Anchor = AnchorStyles.Right;
            error_label.AutoSize = true;
            error_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(360, 225);
            error_label.Name = "error_label";
            error_label.Size = new Size(186, 21);
            error_label.TabIndex = 8;
            error_label.Text = "email/password incorrect";
            error_label.Visible = false;
            // 
            // btn_cancel
            // 
            btn_cancel.AutoSize = true;
            btn_cancel.BackColor = Color.Crimson;
            btn_cancel.Dock = DockStyle.Fill;
            btn_cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(3, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(261, 91);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            btn_login.Dock = DockStyle.Fill;
            btn_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(270, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(261, 91);
            btn_login.TabIndex = 9;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_login, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 379);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(534, 97);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(signup_label, 1, 0);
            tableLayoutPanel2.Location = new Point(164, 307);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(292, 26);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 0;
            label3.Text = "Don't have an account?";
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Dock = DockStyle.Fill;
            signup_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_label.LinkColor = Color.Black;
            signup_label.Location = new Point(149, 0);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(140, 26);
            signup_label.TabIndex = 1;
            signup_label.TabStop = true;
            signup_label.Text = "Register";
            signup_label.LinkClicked += signup_label_LinkClicked;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 488);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(error_label);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(header);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label header;
        private Label label2;
        private MaskedTextBox txt_password;
        private TextBox txt_email;
        private Label error_label;
        private Button btn_cancel;
        private Button btn_login;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private LinkLabel signup_label;
    }
}