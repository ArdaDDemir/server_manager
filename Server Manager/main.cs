using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Management;
using System.Deployment.Application;
using System.Collections;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Server_Manager
{
    public partial class main : Form
    {
        private bool genel;
        private bool teknik;


        public main()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public enum DriveType
        {
            Unknown,         // The type of drive is unknown.  
            NoRootDirectory, // The drive does not have a root directory.  
            Removable,       // The drive is a removable storage device, 
                             //    such as a floppy disk drive or a USB flash drive.  
            Fixed,           // The drive is a fixed disk.  
            Network,         // The drive is a network drive.  
            CDRom,           // The drive is an optical disc device, such as a CD 
                             // or DVD-ROM.  
            Ram              // The drive is a RAM disk.   
        }


        private void main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.game == true)
            {

                game_panel.Visible = true;

            }
            else
            {
                game_panel.Visible = false;

            }
            //İp Çekme
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ip.Text = "İP: " + myIP;
            //İP Çekme Sonu
            //k.adı Çekme
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            k_adı.Text = "K.adı: " + userName;
            //k.adı sonu
            //ram
            string ramSizeInfo = null;

            ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");

            foreach (ManagementObject mObject in ramSearcher.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(mObject["TotalPhysicalMemory"]));
                double ramgb = Ram_Bytes / 1073741824;
                double ramSize = Math.Ceiling(ramgb);
                ramSizeInfo = ramSize.ToString() + " GB";
            }

            tram.Text = "Ram: " + ramSizeInfo;


            //ram son
    
            //cpu
            ManagementObjectSearcher mos =
            new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                cpu.Text = "İşlemci: " + mo["Name"];
            }
            //cpu son
            //İşletim Sistemi

            string r = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        r = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                    }
                }
                r = r.Replace("NT 5.1.2600", "XP");
                r = r.Replace("NT 5.2.3790", "Server 2003");
                os.Text = "İşletim Sistemi: " + (r);
            }
            //İşletim Sistemi son
            //Ekran kartı
            using (var searcher1 = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher1.Get())
                {
                    gpu.Text = ("Ekran Kartı: " + obj["Name"]);
                }
            }
            //ekran kartı son
            //harddrive

          
            string diskKalanBosAlan = "";
            string diskToplamAlan = "";
            int index = 0;
            foreach (DriveInfo disk in DriveInfo.GetDrives())
            {

                if (disk.IsReady)
                {
                    diskKalanBosAlan += "Disk " + index + " üzerindeki boş alan: " + Math.Round(disk.TotalFreeSpace / Math.Pow(1024, 3), 2) + " GB\n";
                    diskToplamAlan += "Disk " + index + " üzerindeki toplam alan: " + Math.Round(disk.TotalSize / Math.Pow(1024, 3), 2) + " GB\n";
                }
                index++;
            }
            disk2.Text =  diskKalanBosAlan + diskToplamAlan;

        
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (genel)
            {
                teknik_panel.Location = new Point(3, 84);
                genel_panel.Height += 300;
                if (genel_panel.Size == genel_panel.MaximumSize)
                {
                    genel_timer.Stop();
                    genel = false;
                }
            }
            else
            {
                teknik_panel.Location = new Point(3, 35);
                genel_panel.Height -= 300;
                if (genel_panel.Size == genel_panel.MinimumSize)
                {
                    genel_timer.Stop();
                    genel = true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            genel_timer.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           teknik_timer.Start();

        }

        private void teknik_timer_Tick(object sender, EventArgs e)
        {
            if (teknik)
            {
                teknik_panel.Height += 300;
                if (teknik_panel.Size == teknik_panel.MaximumSize)
                {
                    teknik_timer.Stop();
                    teknik = false;
                }
            }
            else
            {
                teknik_panel.Height -= 300;
                if (teknik_panel.Size == teknik_panel.MinimumSize)
                {
                    teknik_timer.Stop();
                    teknik = true;
                }
            }
        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");        }



        private void label2_Click(object sender, EventArgs e)
        {
            network network = new network();
            network.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void teknik_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void genel_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
