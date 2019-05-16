using SyncPlayer.SignForms;
using System;
using System.Windows.Forms;

namespace SyncPlayer
{
    internal static class Program
    {
        #region Private Methods

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInForm());
        }

        #endregion Private Methods
    }
}