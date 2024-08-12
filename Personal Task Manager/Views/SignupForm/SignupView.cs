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

namespace Personal_Task_Manager.Views.SignupForm
{
    public partial class SignupView : Form, ISignupView
    {
        #region Properties

        public string FirstName { get => txt_signup_firstname.Text; set => txt_signup_firstname.Text = value; }
        public string LastName { get => txt_signup_firstname.Text; set => txt_signup_firstname.Text = value; }
        public string Email { get => txt_signup_firstname.Text; set => txt_signup_firstname.Text = value; }
        public string Password { get => txt_signup_lastname.Text; set => txt_signup_lastname.Text = value; }


        public event EventHandler<SignupEventClickArgs> _signupEvent;

        #endregion



        #region Constructor
        public SignupView()
        {
            InitializeComponent();
        }

        #endregion



        #region Methods

        public void ShowError(string error)
        {
            error_label_signup.Visible = true;
            error_label_signup.Text = error;
        }

        private void txt_signup_email_TextChanged(object sender, EventArgs e)
        {
            error_label_signup.Visible = false;
        }

        private void txt_signup_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            error_label_signup.Visible = false;
        }

        private void btn_signup_login_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                FirstName = txt_signup_firstname.Text,
                LastName = txt_signup_lastname.Text,
                Email = txt_signup_email.Text,
                Password = txt_signup_password.Text,
            };
            _signupEvent?.Invoke(this, new SignupEventClickArgs(user));
        }

        private void btn_signup_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion



        #region Events

        public class SignupEventClickArgs : EventArgs
        {
            public User User { get; set; }
            public SignupEventClickArgs(User user)
            {
                User = user;
            }
        }

        #endregion

    }
}
