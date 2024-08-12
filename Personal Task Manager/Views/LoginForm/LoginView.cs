﻿using Personal_Task_Manager.Models;
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

        public event EventHandler<LoginEventClickArgs> _login;

        #endregion

        #region Constructor
        public LoginView()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public void Show()
        {
            this.Show();
        }

        public void Hide()
        {
            this.Hide();
        }

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

        private void link_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_login != null)
            {
                _login?.Invoke(this, new LoginEventClickArgs(Email, Password));
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

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
