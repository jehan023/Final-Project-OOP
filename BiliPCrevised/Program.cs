﻿using System;
using System.Windows.Forms;

namespace BiliPC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginUI login = new LoginUI())
            {
                Application.Run(login);
            }

        }
    }
}
