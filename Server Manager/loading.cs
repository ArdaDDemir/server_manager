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

namespace Server_Manager
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {     
                load.Start();

        }

        private void load_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.wait == false)
            {


                loading_bar.Width += 2;
                if (loading_bar.Width >= 260)
                {
                    if (loading_bar.Width != 260)
                    {


                    }
                    else
                    {
                        main ff = new main();
                        loading ff1 = new loading();

                        ff.Show();  // form2 göster diyoruz
                        this.Hide();
                        ff1.Close();   // bu yani form1 gizle diyoruz

                    }
                    load.Stop();
                }

            }
            else
            {
                main ff = new main();
                loading ff1 = new loading();
                ff.Show();  // form2 göster diyoruz
                this.Hide();
                ff1.Close();   // bu yani form1 gizle diyoruz           
                load.Stop();

            }
        }
    }
}
