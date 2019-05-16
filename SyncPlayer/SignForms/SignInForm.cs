using SyncPlayer.Helpers;
using SyncPlayer.Models;
using SyncPlayer.WorkerForms;
using System;

namespace SyncPlayer.SignForms
{
    //TODO: Refactor after libs
    public partial class SignInForm : MaterialSkin.Controls.MaterialForm
    {
        #region Public Constructors

        public SignInForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tbox_email.TextLength >= 5)
            {
                string email = tbox_email.Text;
                string password = tbox_password.Text;
                //httpPost validation
                if (SessionHelper.SetActiveUserSession(new ApplicationUser { Username = email, Password = password }))
                {
                    if (cbox_remMe.Checked == true)
                    {
                        Properties.Settings.Default.remEmail = email;
                        Properties.Settings.Default.remPassword = password;
                        Properties.Settings.Default.Save();
                    }
                    ConnectToRoomForm connectToRoomForm = new ConnectToRoomForm();
                    this.Hide();
                    connectToRoomForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                tbox_email.Focus();
            }
        }

        private void linkLab_forgotPasw_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            this.Hide();
            forgotForm.ShowDialog();
            this.Show();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            //Remember me system // load info
            tbox_email.Text = Properties.Settings.Default.remEmail;
            tbox_password.Text = Properties.Settings.Default.remPassword;
            if (tbox_email.TextLength >= 5)
            {
                if (cbox_remMe.Checked == false) cbox_remMe.Checked = true;
            }
        }

        #endregion Private Methods

        private void RegisterLB_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            this.Close();
            
        }
    }
}