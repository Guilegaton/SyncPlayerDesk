using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncPlayer.SignForms
{
    public partial class ForgotPasswordForm : MaterialSkin.Controls.MaterialForm
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            Close();
        }
    }
}
