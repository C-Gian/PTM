namespace Personal_Task_Manager.Views.SignupForm
{
    partial class SignupView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_signup_cancel = new Button();
            btn_signup_login = new Button();
            error_label_signup = new Label();
            txt_signup_firstname = new TextBox();
            label2 = new Label();
            header = new Label();
            label1 = new Label();
            txt_signup_email = new TextBox();
            txt_signup_password = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            txt_signup_lastname = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_signup_cancel, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_signup_login, 1, 0);
            tableLayoutPanel1.Location = new Point(9, 555);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(534, 97);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // btn_signup_cancel
            // 
            btn_signup_cancel.AutoSize = true;
            btn_signup_cancel.BackColor = Color.Crimson;
            btn_signup_cancel.Dock = DockStyle.Fill;
            btn_signup_cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signup_cancel.ForeColor = Color.White;
            btn_signup_cancel.Location = new Point(3, 3);
            btn_signup_cancel.Name = "btn_signup_cancel";
            btn_signup_cancel.Size = new Size(261, 91);
            btn_signup_cancel.TabIndex = 10;
            btn_signup_cancel.Text = "cancel";
            btn_signup_cancel.UseVisualStyleBackColor = false;
            btn_signup_cancel.Click += btn_signup_cancel_Click;
            // 
            // btn_signup_login
            // 
            btn_signup_login.Dock = DockStyle.Fill;
            btn_signup_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signup_login.Location = new Point(270, 3);
            btn_signup_login.Name = "btn_signup_login";
            btn_signup_login.Size = new Size(261, 91);
            btn_signup_login.TabIndex = 9;
            btn_signup_login.Text = "Signup";
            btn_signup_login.UseVisualStyleBackColor = true;
            btn_signup_login.Click += btn_signup_login_Click;
            // 
            // error_label_signup
            // 
            error_label_signup.Anchor = AnchorStyles.Right;
            error_label_signup.AutoSize = true;
            error_label_signup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error_label_signup.ForeColor = Color.Red;
            error_label_signup.Location = new Point(377, 308);
            error_label_signup.Name = "error_label_signup";
            error_label_signup.Size = new Size(170, 21);
            error_label_signup.TabIndex = 17;
            error_label_signup.Text = "problem during signup";
            error_label_signup.Visible = false;
            // 
            // txt_signup_firstname
            // 
            txt_signup_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_signup_firstname.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signup_firstname.Location = new Point(9, 141);
            txt_signup_firstname.Name = "txt_signup_firstname";
            txt_signup_firstname.Size = new Size(538, 39);
            txt_signup_firstname.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 202);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 14;
            label2.Text = "Lastname";
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top;
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(178, 38);
            header.Name = "header";
            header.Size = new Size(192, 65);
            header.TabIndex = 13;
            header.Text = "Signup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 108);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 12;
            label1.Text = "Firstname";
            // 
            // txt_signup_email
            // 
            txt_signup_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_signup_email.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signup_email.Location = new Point(9, 334);
            txt_signup_email.Name = "txt_signup_email";
            txt_signup_email.Size = new Size(538, 39);
            txt_signup_email.TabIndex = 22;
            txt_signup_email.TextChanged += txt_signup_email_TextChanged;
            // 
            // txt_signup_password
            // 
            txt_signup_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_signup_password.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signup_password.Location = new Point(9, 428);
            txt_signup_password.Name = "txt_signup_password";
            txt_signup_password.PasswordChar = '*';
            txt_signup_password.Size = new Size(538, 39);
            txt_signup_password.TabIndex = 21;
            txt_signup_password.MaskInputRejected += txt_signup_password_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 395);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 301);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 19;
            label4.Text = "Email";
            // 
            // txt_signup_lastname
            // 
            txt_signup_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_signup_lastname.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_signup_lastname.Location = new Point(9, 235);
            txt_signup_lastname.Name = "txt_signup_lastname";
            txt_signup_lastname.Size = new Size(538, 39);
            txt_signup_lastname.TabIndex = 23;
            // 
            // SignupView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 697);
            Controls.Add(txt_signup_lastname);
            Controls.Add(txt_signup_email);
            Controls.Add(txt_signup_password);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(error_label_signup);
            Controls.Add(txt_signup_firstname);
            Controls.Add(label2);
            Controls.Add(header);
            Controls.Add(label1);
            Name = "SignupView";
            Text = "Signup";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_signup_cancel;
        private Button btn_signup_login;
        private Label error_label_signup;
        private TextBox txt_signup_firstname;
        private Label label2;
        private Label header;
        private Label label1;
        private TextBox txt_signup_email;
        private MaskedTextBox txt_signup_password;
        private Label label3;
        private Label label4;
        private TextBox txt_signup_lastname;
    }
}