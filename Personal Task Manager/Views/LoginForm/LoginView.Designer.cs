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
            link_forgot = new LinkLabel();
            error_label = new Label();
            btn_cancel = new Button();
            btn_login = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
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
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(187, 36);
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
            // link_forgot
            // 
            link_forgot.AutoSize = true;
            link_forgot.LinkColor = Color.Gray;
            link_forgot.Location = new Point(16, 314);
            link_forgot.Name = "link_forgot";
            link_forgot.Size = new Size(157, 15);
            link_forgot.TabIndex = 6;
            link_forgot.TabStop = true;
            link_forgot.Text = "Forgot Password? Click Here";
            link_forgot.LinkClicked += link_forgot_LinkClicked;
            // 
            // error_label
            // 
            error_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            error_label.AutoSize = true;
            error_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(187, 369);
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
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_login, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(534, 97);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 521);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(error_label);
            Controls.Add(link_forgot);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(header);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label header;
        private Label label2;
        private MaskedTextBox txt_password;
        private TextBox txt_email;
        private LinkLabel link_forgot;
        private Label error_label;
        private Button btn_cancel;
        private Button btn_login;
        private TableLayoutPanel tableLayoutPanel1;
    }
}