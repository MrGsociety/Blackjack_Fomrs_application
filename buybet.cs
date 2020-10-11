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
    public partial class buybet : UserControl
    {
        public buybet()
        {
            InitializeComponent();
        }
        static int allbet;
        static string path = @"C:\Users\Public\Blackjack\surrounding.gif";
        static string mpath = @"C:\Users\Public\Blackjack\diasirres.mp4";
        static string[] user_data_m = File.ReadAllLines(mpath);
        static int money;
        static int zsnyeton;
        private void bet_out_btn_Click(object sender, EventArgs e)
        {        
            money = Convert.ToInt32(user_data_m[0]);    
            try
            {
                allbet = Convert.ToInt32(bet_out_txtb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hibásan bevitt adat. Próbáld újra.", "Hibás adat...", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            if (allbet > money)
            {
                MessageBox.Show("Nem áll rendelkezésre megfelelő mennyiségű pénz", "Csoróóó", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bet_out_txtb.Clear();
            }

            if (!(File.Exists(path)))
            {
                string abet = allbet.ToString();
                string[] user_data_be = { abet };
                File.WriteAllLines(path, user_data_be);
            }
        }
    }
}
