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
using NetFwTypeLib;


namespace Server_Manager
{
    public partial class network : Form
    {
        private bool genel;
        private bool firewallpanel;
        private bool portpanel;


        public network()
        {
            InitializeComponent();
        }


        static string Mac()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }

            return String.Empty;
        }

 

        private void network_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.game == true)
            {

                game_panel.Visible = true;

            }
            else
            {
                game_panel.Visible = false;

            }
            string mac = Mac();

            if (String.IsNullOrEmpty(mac))
            {
                maca.Text = ("Bilgisayarınızda bir ağ bağdaştırıcısı bulunamadı.");
            }
            else
            {
                maca.Text = ("Mac adresiniz: " + mac);
            }
            //İp Çekme
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ip.Text = "İP: " + myIP;
            //İP Çekme Sonu
            //Güvenlik Duvarı Başlangıç
            Type type = Type.GetTypeFromProgID("HNetCfg.FwMgr");
            dynamic dy = Activator.CreateInstance(type);
            bool aktif = dy.LocalPolicy.CurrentProfile.FirewallEnabled;
            if (aktif)
                firewall.Text = "Güvenlik Duvarı: Aktif";
            else
            {
                firewall.Text = "Güvenlik Duvarı: Kapalı";
            }
        }

        private void genel_timer_Tick(object sender, EventArgs e)
        {
            if (genel)
            {
                firewall_panel.Location = new Point(-1, 89);
                if (firewallpanel == false)
                {
                    port_panel.Location = new Point(-1, 205);

                }
else
                {
                    port_panel.Location = new Point(-1, 125);

                }

                genel_panel.Height += 300;
                if (genel_panel.Size == genel_panel.MaximumSize)
                {
                    genel_timer.Stop();
                    genel = false;
                }
            }
            else
            {
                firewall_panel.Location = new Point(-1, 35);
                if (firewallpanel == false)
                {
                    port_panel.Location = new Point(-1, 152);

                }

                else
                {
                    port_panel.Location = new Point(-1, 75);

                }
                genel_panel.Height -= 300;
                if (genel_panel.Size == genel_panel.MinimumSize)
                {
                    genel_timer.Stop();
                    genel = true;
                }
            }
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            main genel = new main();
            network network = new network();

            genel.Show();  // form2 göster diyoruz
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            genel_timer.Start();

        }

        private void firewall_change_1_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                string top = "netsh.exe";
                proc.StartInfo.Arguments = "Firewall set opmode enable";
                proc.StartInfo.FileName = top;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                MessageBox.Show("Güvenlik Duvarı Açıldı", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Type type = Type.GetTypeFromProgID("HNetCfg.FwMgr");
                dynamic dy = Activator.CreateInstance(type);
                bool aktif = dy.LocalPolicy.CurrentProfile.FirewallEnabled;
                if (aktif)
                    firewall.Text = "Güvenlik Duvarı: Aktif";
                else
                {
                    firewall.Text = "Güvenlik Duvarı: Kapalı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firewall_change_0_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                string top = "netsh.exe";
                proc.StartInfo.Arguments = "Firewall set opmode disable";
                proc.StartInfo.FileName = top;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                MessageBox.Show("Güvenlik Duvarı Kapatıldı", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Type type = Type.GetTypeFromProgID("HNetCfg.FwMgr");
                dynamic dy = Activator.CreateInstance(type);
                bool aktif = dy.LocalPolicy.CurrentProfile.FirewallEnabled;
                if (aktif)
                    firewall.Text = "Güvenlik Duvarı: Aktif";
                else
                {
                    firewall.Text = "Güvenlik Duvarı: Kapalı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firewall_timer_Tick(object sender, EventArgs e)
        {
            if (firewallpanel)
            {
                firewall_panel.Height += 300;
                if (genel == false)
                {
                    port_panel.Location = new Point(-1, 202);

                }

                else
                {
                    port_panel.Location = new Point(-1, 152);

                }
                if (firewall_panel.Size == firewall_panel.MaximumSize)
                {

                    firewall_timer.Stop();
                    firewallpanel = false;
                }
            }
            else
            {
                firewall_panel.Height -= 300;
                if (genel == false)
                {
                    port_panel.Location = new Point(-1, 125);

                }

                else
                {
                    port_panel.Location = new Point(-1, 75);

                }
                if (firewall_panel.Size == firewall_panel.MinimumSize)
                {
                    firewall_timer.Stop();
                    firewallpanel = true;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            firewall_timer.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            var currentProfiles = fwPolicy2.CurrentProfileTypes;
            INetFwRule firewallRule = fwPolicy2.Rules.OfType<INetFwRule>().Where(
                x => x.Name == port_name.Text)
                .FirstOrDefault(); // Koymak istediğiniz kural ile kayıtlı kayıt var mı diye kontrol ediyoruz
            if (firewallRule == null)
            {
                INetFwRule2 inboundRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                inboundRule.Enabled = true;
                inboundRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                inboundRule.Protocol = 6; // TCP Protokol Numarası
                inboundRule.LocalPorts = port_id.Text; // Açmak istediğiniz port
                inboundRule.Name = port_name.Text; // Kural ismi
                inboundRule.Profiles = currentProfiles;
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(inboundRule);
                MessageBox.Show("Kural Başarılı Bir Şekilde Oluşturuldu.", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu Kural Mevcut.", "Güvenlik Duvarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void port_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void port_timer_Tick(object sender, EventArgs e)
        {
            if (portpanel)
            {
                port_panel.Height += 300;
                if (port_panel.Size == port_panel.MaximumSize)
                {
                    port_timer.Stop();
                    portpanel = false;
                }
            }
            else
            {
                port_panel.Height -= 300;
                if (port_panel.Size == port_panel.MinimumSize)
                {
                    port_timer.Stop();
                    portpanel = true;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            port_timer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void panel3_Click(object sender, PaintEventArgs e)
        {
  
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void network_Click(object sender, EventArgs e)
        {
            game game = new game();
            game.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }
    }
}
