using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PathCopier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static frmPopup Frm;

        [STAThread]
        static void Main(string[] args)
        {
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings.Load();
            Frm = new frmPopup();
            if ( Frm.Popup(args) )
            {
            Application.Run();
            }
            else
            {
                Application.Run(new Setup());
            }
            
        }

	
    }
}