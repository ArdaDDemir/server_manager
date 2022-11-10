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
using System.Net;

namespace Server_Manager
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        private bool program1;



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            network network = new network();
            network.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void label3_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();  // form2 göster diyoruz
            this.Close();   // bu yani form1 gizle diyoruz
        }

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void game_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:/Zaytron/Chrome.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                button1.Text = "Kur";
                ChromeBar.Visible = false;

            }
            if (File.Exists("C:/Zaytron/Notepad.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                button2.Text = "Kur";
                notepadbar.Visible = false;

            }
            if (File.Exists("C:/Zaytron/java.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                button3.Text = "Kur";
                javabar.Visible = false;

            }
        }

        private void program1_panel_Click(object sender, EventArgs e)
        {
            program1_timer.Start();
        }

        private void program1_timer_Tick(object sender, EventArgs e)
        {
            if (program1)
            {
                program1_panel.Height += 300;
                if (program1_panel.Size == program1_panel.MaximumSize)
                {
                    program1_timer.Stop();
                    program1 = false;
                }
            }
            else
            {
                game_panel.Height -= 300;
                if (game_panel.Size == game_panel.MinimumSize)
                {
                    program1_timer.Stop();
                    program1 = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists("C:/Zaytron/Chrome.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                System.Diagnostics.Process.Start("C:/Zaytron/Chrome.exe");
                button1.Text = "Kuruldu";
                ChromeBar.Visible = false;


            }
            else
            {
                button1.Text = "İndir";

                ChromeBar.Visible = true;
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileAsync(new Uri("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BA222F4F4-3CD4-5C34-B33B-9BF631B3FBBD%7D%26lang%3Dtr%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe".Trim()), @"c:\Zaytron\" + "Chrome" + Path.GetExtension("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BA222F4F4-3CD4-5C34-B33B-9BF631B3FBBD%7D%26lang%3Dtr%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe"));
                button1.Text = "Kur";

            }

        }
        public void wc_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)

        {

            ChromeBar.Value = e.ProgressPercentage;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (File.Exists("C:/Zaytron/Notepad.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                System.Diagnostics.Process.Start("C:/Zaytron/Notepad.exe");
                button2.Text = "Kuruldu";
                notepadbar.Visible = false;


            }
            else
            {
                button2.Text = "İndir";

                notepadbar.Visible = true;
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged1);
                wc.DownloadFileAsync(new Uri("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.4.4/npp.8.4.4.Installer.x64.exe".Trim()), @"c:\Zaytron\" + "Notepad" + Path.GetExtension("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.4.4/npp.8.4.4.Installer.x64.exe"));
                button2.Text = "Kur";

            }

        }
        public void wc_DownloadProgressChanged1(Object sender, DownloadProgressChangedEventArgs e)

        {

            notepadbar.Value = e.ProgressPercentage;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:/Zaytron/java.exe") == true) // dizindeki dosya var mı ?
            {
                // varsa
                System.Diagnostics.Process.Start("C:/Zaytron/java.exe");
                button3.Text = "Kuruldu";
                javabar.Visible = false;


            }
            else
            {
                button3.Text = "İndir";

                javabar.Visible = true;
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged2);
                wc.DownloadFileAsync(new Uri("https://sdlc-esd.oracle.com/ESD6/JSCDL/jdk/8u341-b10/424b9da4b48848379167015dcc250d8d/jre-8u341-windows-x64.exe?GroupName=JSC&FilePath=/ESD6/JSCDL/jdk/8u341-b10/424b9da4b48848379167015dcc250d8d/jre-8u341-windows-x64.exe&BHost=javadl.sun.com&File=jre-8u341-windows-x64.exe&AuthParam=1659017660_959529870e76ea57bf621b855c5957a7&ext=.exe".Trim()), @"c:\Zaytron\" + "java" + Path.GetExtension("https://sdlc-esd.oracle.com/ESD6/JSCDL/jdk/8u341-b10/424b9da4b48848379167015dcc250d8d/jre-8u341-windows-x64.exe?GroupName=JSC&FilePath=/ESD6/JSCDL/jdk/8u341-b10/424b9da4b48848379167015dcc250d8d/jre-8u341-windows-x64.exe&BHost=javadl.sun.com&File=jre-8u341-windows-x64.exe&AuthParam=1659017660_959529870e76ea57bf621b855c5957a7&ext=.exe"));
                button3.Text = "Kur";

            }

        }
        public void wc_DownloadProgressChanged2(Object sender, DownloadProgressChangedEventArgs e)

        {

            javabar.Value = e.ProgressPercentage;

        }
    }
}
