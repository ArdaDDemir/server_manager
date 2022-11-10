using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Server_Manager.Properties;
using Microsoft.Win32;


namespace Server_Manager
{
    public partial class settings : Form
    {


        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
          if (Properties.Settings.Default.startup == true)
            {
                startup_check.CheckState = CheckState.Checked;
            }
; if (Properties.Settings.Default.beta == true)
            {
                beta.CheckState = CheckState.Checked;

            }
            if (beta.Checked)
            {

                wait_check.Visible = true;
                if (Properties.Settings.Default.wait == true)
                {
                    wait_check.CheckState = CheckState.Checked;

                }
                game_check.Visible = true;
                if (Properties.Settings.Default.game == true)
                {
                    game_check.CheckState = CheckState.Checked;

                }
            }
            else
            {
                wait_check.Visible = false;
                game_check.Visible = false;


            }
            if (Properties.Settings.Default.game == true)
            {
                game_panel.Visible = true;
            }
            else
            {
                game_panel.Visible = false;

            }
        }



        private void startup_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.beta = beta.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.startup = startup_check.Checked;
            Properties.Settings.Default.Save();
            
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (beta.Checked)
            {
                Properties.Settings.Default.game = game_check.Checked;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.wait = wait_check.Checked;
                Properties.Settings.Default.Save();
                wait_check.Visible = true;
                game_check.Visible = true;
                if (Properties.Settings.Default.game == true)
                {

                    game_check.CheckState = CheckState.Checked;
                    game_panel.Visible = true;
                   
                }
                else
                {
                    game_panel.Visible = false;

                }

                if (Properties.Settings.Default.wait == true)
                {
                    wait_check.CheckState = CheckState.Checked;


                }
            }
            else
            {
                wait_check.Visible = false;
                game_check.Visible = false;
                Properties.Settings.Default.wait = wait_check.Checked;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.game = game_check.Checked;
                Properties.Settings.Default.Save();

            }

            if (startup_check.Checked)
                rk.SetValue("ArdaDDemir", Application.ExecutablePath);
            else
                rk.DeleteValue("ArdaDDemir", false);
            MessageBox.Show("Ayarlar Başarıyla Kaydedildi","Ayarlar",MessageBoxButtons.OK, MessageBoxIcon.Information); ;


        }

        private void wait_check_Click(object sender, EventArgs e)
        {
            if (wait_check.Checked)
            {
                MessageBox.Show("Yükleme ekranını kapatmak hatalara yol açabilir", "Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }


        }

        private void beta_Click(object sender, EventArgs e)
        {
            if (beta.Checked)
            {
                MessageBox.Show("Geliştirici modu açıldı", "Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
        }



        private void panel1_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void game_check_Click(object sender, EventArgs e)
        {
            if (game_check.Checked)
            {
                MessageBox.Show("Oyun modu açıldı", "Ayarlar", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            network network = new network();
            network.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void label4_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }
    }
}
