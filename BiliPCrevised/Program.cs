namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginUI login = new LoginUI())
            {
                Application.Run(login);
            }

            // Logout when closed normally, doesn't work if closed using task manager
            if (LoginUI.IsLoggedIn == true)
            {
                DashboardUI.Logout();
            }
        }
    }
}
