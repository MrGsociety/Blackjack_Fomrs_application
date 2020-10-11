using System;
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
    public partial class game_board_cs : Form
    {
        public game_board_cs()
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

        private void game_board_cs_Load(object sender, EventArgs e)
        {

        }
    }
}
