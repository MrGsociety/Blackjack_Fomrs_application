using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_form_application
{
    public partial class getbet : UserControl
    {
        public getbet()
        {
            InitializeComponent();
        }
        static int allbet;
        static string path = @"C:\Users\Public\Blackjack\bet.gif";
        private void bet_ki_btn_Click(object sender, EventArgs e)
        {
            try
            {
                allbet = Convert.ToInt32(bet_ki_txtb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hibásan bevitt adat. Próbáld újra.", "Hibás adat...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!(File.Exists(path)))
            {
                string[] user_data_fi = File.ReadAllLines(path);

            }
        }
    }
}
