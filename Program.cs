using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace blackjack_form_application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void xd()
        {
            string[] user_data_ex = { "Default", "" };
            string path = @"C:\Users\Public\Blackjack\logo.gif";
            string mpath = @"C:\Users\Public\Blackjack\diasirres.mp4";
           // string pathy = @"C:\Users\Public\Blackjack\usy.txt";
                if (!(Directory.Exists(@"C:\Users\Public\Blackjack")))
                {
                    Directory.CreateDirectory(@"C:\Users\Public\Blackjack");
                }
                else if (!(File.Exists(path)))
                {
                    File.WriteAllLines(path, user_data_ex);
                }
                if (!(File.Exists(mpath)))
                {
                    File.Create(mpath);
                }
        }
        
        static void Main()
        {
            xd();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Distributor());
        }
    }
}
