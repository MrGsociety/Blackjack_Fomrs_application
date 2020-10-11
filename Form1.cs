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
using System.Security.Cryptography;

namespace blackjack_form_application
{
    public partial class Distributor : Form
    {
        static string path = @"C:\Users\Public\Blackjack\logo.gif";

        public Distributor()
        {
            InitializeComponent();
            login_as_btn.Text = "Belépés mint: " + user_data_i[0];
        }
        static string reg_namenome, reg_password, log_namenome, log_password;        
        static string[] user_data_i = File.ReadAllLines(path);
        static string[] password_hash = new string[200];

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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_check_CheckedChanged(object sender, EventArgs e)
        {
            if (reg_uname_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet a felhasználónév üres", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
                reg_check.Checked = false;
            }
            else if (reg_password_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet a jelszó üres", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
                reg_check.Checked = false;
            }
            else if (reg_password_again_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet a jelszó üres", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled =  false;
                reg_check.Checked = false;
            }
            else if (!(reg_password_txtb.Text == reg_password_again_txtb.Text))
            {
                MessageBox.Show("Nem egyezik a két jelszó", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_btn.Enabled = false;
                reg_check.Checked = false;
            }
            else
            {
                register_btn.Enabled = true;                
            }
            
        }

        private void log_check_CheckedChanged(object sender, EventArgs e)
        {
            if (log_username_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet a felhasználónév üres", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log_me_in_btn.Enabled = false;
                log_check.Checked = false;
            }
            else if (log_password_txtb.Text == "")
            {
                MessageBox.Show("Nem lehet a jelszó üres", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log_me_in_btn.Enabled = false;
                log_check.Checked = false;
            }
            else
            {
                log_me_in_btn.Enabled = true;                
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            reg_namenome = Convert.ToString(reg_uname_txtb.Text);
            reg_password = Convert.ToString(reg_password_txtb.Text);
            reg_password_txtb.MaxLength = 50;
            if (reg_password.Length > 50)
            {
                MessageBox.Show("50 karatkernél NEM nagyobb jelszót írj be");
            }
            else
            {
                if (!(Directory.Exists(@"C:\Users\Public\Blackjack")))
                {
                    Directory.CreateDirectory(@"C:\Users\Public\Blackjack");
                }
                SHA1 sha = new SHA1CryptoServiceProvider();
                string text = reg_password;                
                byte[] hashedData = sha.ComputeHash(Encoding.Unicode.GetBytes(text));
                StringBuilder stringBuilder = new StringBuilder();
                int i = 0;
                foreach (byte b in hashedData)
                {
                    stringBuilder.Append(String.Format("{0,2:X2}", b));
                    password_hash[i] = Convert.ToString(b);
                    i++;
                }
                string sh = string.Join("", password_hash);
                string[] user_data_e = { reg_namenome, sh };
                File.WriteAllLines(path, user_data_e);
                MessageBox.Show("" + reg_namenome + " sikeresen létrehozva!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                register_panel.Hide();
            }             
        }

        private void log_me_in_btn_Click(object sender, EventArgs e)
        {
            if (!(Directory.Exists(@"C:\Users\Public\Blackjack")))
            {
                Directory.CreateDirectory(@"C:\Users\Public\Blackjack");
            }
            else if (!(File.Exists(path)))
            {
                MessageBox.Show("Nincsen 1 felhasználói fiókod sem. Kérek regisztrálj, majd utána jelentkezz be", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                register_panel.Show();
            }
            else
            {
                log_namenome = Convert.ToString(log_username_txtb.Text);
                log_password = Convert.ToString(log_password_txtb.Text);                
                login_as_btn.Text = user_data_i[0];
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                string texty = log_password;
                byte[] hashedDatalog = sha1.ComputeHash(Encoding.Unicode.GetBytes(texty));
                StringBuilder stringBuilderL = new StringBuilder();
                string[] pswd_hsh = new string[200];      
                int ei = 0;
                foreach (byte c in hashedDatalog)
                {
                    stringBuilderL.Append(String.Format("{0,2:X2}", c));
                    pswd_hsh[ei] = Convert.ToString(c);
                    ei++;
                }
                string sha = string.Join("", pswd_hsh);
                if (!(user_data_i[0] == log_namenome))
                {
                    MessageBox.Show("Helytelen felhasználónév", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log_username_txtb.Clear();
                }
                else if (!(user_data_i[1] == sha))
                {
                    MessageBox.Show("Helytelen jelszó", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sikeres bejelentkezés", "Engedélyezve", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    register_panel.Hide();
                    login_btn.Hide();
                    Form form1 = new Form();                    
                    bet form2 = new bet();
                    this.Hide();
                    form2.Show();
                }
            }

        }

        private void login_as_btn_Click(object sender, EventArgs e)
        {
            log_username_txtb.Text = user_data_i[0];
            login_as_btn.Hide();
        }

        private void szabalyzat_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Public\Blackjack\service.txt");
        }

        private void Distributor_Load(object sender, EventArgs e)
        {
                if (!(File.Exists(path)))
                {
                    string[] user_data_ex = { "Defu", "" };
                    File.WriteAllLines(path, user_data_ex);
                }
                else
                {
                    MessageBox.Show("Üdvözöllek " + user_data_i[0]);
                }
        }

        private void reg_password_txtb_TextChanged(object sender, EventArgs e)
        {
            reg_password_txtb.PasswordChar = '*';            
        }

        private void reg_password_again_txtb_TextChanged(object sender, EventArgs e)
        {
            reg_password_again_txtb.PasswordChar = '*';
        }

        private void log_password_txtb_TextChanged(object sender, EventArgs e)
        {
            log_password_txtb.PasswordChar = '*';
        }
    }
}
