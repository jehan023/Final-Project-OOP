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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjMzMzY3QDMxMzgyZTMxMmUzMEd2YXV2cTVIWjN4a0Yza000dzB4ZDI2RUlpbjk0WitocnIya09Fd2x5WWc9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginUI login = new LoginUI())
            {
                Application.Run(login);
            }
        }
    }
}
