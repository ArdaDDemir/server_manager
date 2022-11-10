namespace Server_Manager
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.game_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.teknik_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.Label();
            this.disk2 = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.tram = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.genel_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.k_adı = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.Label();
            this.kapat_btn = new System.Windows.Forms.Label();
            this.genel_timer = new System.Windows.Forms.Timer(this.components);
            this.teknik_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.game_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.teknik_panel.SuspendLayout();
            this.genel_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 52);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 52);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "İnternet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-1, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 52);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ayarlar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.Black;
            this.game_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_panel.Controls.Add(this.pictureBox5);
            this.game_panel.Controls.Add(this.label4);
            this.game_panel.Location = new System.Drawing.Point(-1, 232);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(120, 52);
            this.game_panel.TabIndex = 4;
            this.game_panel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oyun";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.teknik_panel);
            this.panel5.Controls.Add(this.genel_panel);
            this.panel5.Location = new System.Drawing.Point(128, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 359);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // teknik_panel
            // 
            this.teknik_panel.Controls.Add(this.label7);
            this.teknik_panel.Controls.Add(this.ip);
            this.teknik_panel.Controls.Add(this.disk2);
            this.teknik_panel.Controls.Add(this.cpu);
            this.teknik_panel.Controls.Add(this.tram);
            this.teknik_panel.Controls.Add(this.gpu);
            this.teknik_panel.Location = new System.Drawing.Point(3, 35);
            this.teknik_panel.MaximumSize = new System.Drawing.Size(366, 218);
            this.teknik_panel.MinimumSize = new System.Drawing.Size(366, 30);
            this.teknik_panel.Name = "teknik_panel";
            this.teknik_panel.Size = new System.Drawing.Size(366, 30);
            this.teknik_panel.TabIndex = 21;
            this.teknik_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.teknik_panel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teknik Bilgiler";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(3, 33);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(15, 13);
            this.ip.TabIndex = 11;
            this.ip.Text = "ip";
            // 
            // disk2
            // 
            this.disk2.AutoSize = true;
            this.disk2.Location = new System.Drawing.Point(3, 122);
            this.disk2.Name = "disk2";
            this.disk2.Size = new System.Drawing.Size(32, 13);
            this.disk2.TabIndex = 18;
            this.disk2.Text = "disk2";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(3, 54);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(25, 13);
            this.cpu.TabIndex = 15;
            this.cpu.Text = "cpu";
            // 
            // tram
            // 
            this.tram.AutoSize = true;
            this.tram.Location = new System.Drawing.Point(4, 76);
            this.tram.Name = "tram";
            this.tram.Size = new System.Drawing.Size(24, 13);
            this.tram.TabIndex = 13;
            this.tram.Text = "ram";
            // 
            // gpu
            // 
            this.gpu.AutoSize = true;
            this.gpu.Location = new System.Drawing.Point(4, 95);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(25, 13);
            this.gpu.TabIndex = 16;
            this.gpu.Text = "gpu";
            // 
            // genel_panel
            // 
            this.genel_panel.Controls.Add(this.label5);
            this.genel_panel.Controls.Add(this.k_adı);
            this.genel_panel.Controls.Add(this.os);
            this.genel_panel.Location = new System.Drawing.Point(3, 3);
            this.genel_panel.MaximumSize = new System.Drawing.Size(366, 80);
            this.genel_panel.MinimumSize = new System.Drawing.Size(366, 30);
            this.genel_panel.Name = "genel_panel";
            this.genel_panel.Size = new System.Drawing.Size(366, 30);
            this.genel_panel.TabIndex = 20;
            this.genel_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.genel_panel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genel Bilgiler";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // k_adı
            // 
            this.k_adı.AutoSize = true;
            this.k_adı.Location = new System.Drawing.Point(13, 35);
            this.k_adı.Name = "k_adı";
            this.k_adı.Size = new System.Drawing.Size(33, 13);
            this.k_adı.TabIndex = 12;
            this.k_adı.Text = "k_adı";
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.Location = new System.Drawing.Point(13, 65);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(18, 13);
            this.os.TabIndex = 14;
            this.os.Text = "os";
            // 
            // kapat_btn
            // 
            this.kapat_btn.AutoSize = true;
            this.kapat_btn.Location = new System.Drawing.Point(488, 14);
            this.kapat_btn.Name = "kapat_btn";
            this.kapat_btn.Size = new System.Drawing.Size(12, 13);
            this.kapat_btn.TabIndex = 7;
            this.kapat_btn.Text = "x";
            // 
            // genel_timer
            // 
            this.genel_timer.Enabled = true;
            this.genel_timer.Interval = 1;
            this.genel_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teknik_timer
            // 
            this.teknik_timer.Enabled = true;
            this.teknik_timer.Interval = 1;
            this.teknik_timer.Tick += new System.EventHandler(this.teknik_timer_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Server_Manager.Properties.Resources.github;
            this.pictureBox6.Location = new System.Drawing.Point(321, 305);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 52);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Server_Manager.Properties.Resources.customer_support;
            this.pictureBox4.Location = new System.Drawing.Point(3, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Server_Manager.Properties.Resources.wifi1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Server_Manager.Properties.Resources.dice1;
            this.pictureBox5.Location = new System.Drawing.Point(3, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Server_Manager.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(3, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server_Manager.Properties.Resources.adlogo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(512, 400);
            this.Controls.Add(this.kapat_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArdaDDemir";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.teknik_panel.ResumeLayout(false);
            this.teknik_panel.PerformLayout();
            this.genel_panel.ResumeLayout(false);
            this.genel_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label tram;
        private System.Windows.Forms.Label k_adı;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label os;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label disk2;
        private System.Windows.Forms.Label gpu;
        private System.Windows.Forms.Label kapat_btn;
        private System.Windows.Forms.Timer genel_timer;
        private System.Windows.Forms.Panel genel_panel;
        private System.Windows.Forms.Panel teknik_panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer teknik_timer;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}