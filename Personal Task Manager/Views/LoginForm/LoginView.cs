using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Task_Manager.Views.LoginForm
{
    public partial class LoginView : Form, ILoginView
    {

        #region Properties

        public string Email { get => txt_email.Text; set => txt_email.Text = value; }
        public string Password { get => txt_password.Text; set => txt_password.Text = value; }

        public event EventHandler<LoginEventClickArgs> _loginEvent;
        public event EventHandler _signupClickEvent;

        #endregion




        #region Constructor
        public LoginView()
        {
            InitializeComponent();
        }

        #endregion




        #region Methods

        public void ShowError()
        {
            error_label.Visible = true;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void txt_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            error_label.Visible = false;
        }

        private void signup_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _signupClickEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _loginEvent?.Invoke(this, new LoginEventClickArgs(Email, Password));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion




        #region Events

        public class LoginEventClickArgs : EventArgs
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public LoginEventClickArgs(string email, string password)
            {
                Email = email;
                Password = password;
            }
        }

        #endregion



        
    }
}
