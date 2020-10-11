using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_form_application
{
    public partial class bet : Form
    {
        public bet()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keydata)
        {
            if (keydata == (Keys.Alt | Keys.F4))
            {
                MessageBox.Show("Használd a 'Kilépés' gombot", "ALT+F4 észlelve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keydata);
        }
        static string mpath = @"C:\Users\Public\Blackjack\diasirres.mp4";
        private void buybet_btn_Click(object sender, EventArgs e)
        {
            buybet newy = new buybet();
            usercontrol_panel.Controls.Add(newy);
            getbet_btn.Hide();
            exit_btn.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            usercontrol_panel.Controls.Clear();
            buybet_btn.Show();
            getbet_btn.Show();
            exit_btn.Show();
        }

        private void getbet_btn_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"C:\Users\Public\Blackjack\bet.gif"))
            {
                getbet gety = new getbet();
                usercontrol_panel.Controls.Add(gety);
                buybet_btn.Hide();
                exit_btn.Hide();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bet_Load(object sender, EventArgs e)
        {

        }
    }
}
