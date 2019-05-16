using SyncPlayer.Helpers;
using SyncPlayer.Models;
using SyncPlayer.WorkerForms;
using System;
using System.Configuration;
using System.Linq;

namespace SyncPlayer.SignForms
{
    public partial class SignUpForm : MaterialSkin.Controls.MaterialForm
    {
        #region Public Constructors

        public SignUpForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tbox_email.TextLength >= 5 && tbox_password.TextLength >= 5 && tbox_repeatPasw.TextLength >= 5)
            {
                if (tbox_password.Text == tbox_repeatPasw.Text)
                {
                    string email = tbox_email.Text;
                    string password = tbox_password.Text;
                    var user = new ApplicationUser() { Username = email, Password = password };
                    if (new HttpHelper().Request(user, ConfigurationManager.AppSettings["ServerHost"] + "api/Auth/Register"))
                    {
                        SessionHelper.SetActiveUserSession(user);
                        //Remember me system
                        Properties.Settings.Default.remEmail = email;
                        Properties.Settings.Default.remPassword = password;
                        Properties.Settings.Default.Save();
                        ConnectToRoomForm connectToRoomForm = new ConnectToRoomForm();
                        connectToRoomForm.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    tbox_repeatPasw.Text = string.Empty;
                    tbox_repeatPasw.Focus();
                }
            }
            else
            {
                tbox_email.Focus();
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateForm()
        {
            return tbox_email.Text.Contains("@")
                   && tbox_email.Text.Split('@').Last().Contains(".");
        }

        #endregion Private Methods
    }
}