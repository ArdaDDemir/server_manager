namespace Server_Manager
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.loading_bar = new System.Windows.Forms.Panel();
            this.load = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_bar
            // 
            this.loading_bar.BackColor = System.Drawing.Color.White;
            this.loading_bar.Location = new System.Drawing.Point(-2, 247);
            this.loading_bar.MaximumSize = new System.Drawing.Size(300, 10);
            this.loading_bar.Name = "loading_bar";
            this.loading_bar.Size = new System.Drawing.Size(10, 10);
            this.loading_bar.TabIndex = 0;
            // 
            // load
            // 
            this.load.Enabled = true;
            this.load.Interval = 27;
            this.load.Tick += new System.EventHandler(this.load_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server_Manager.Properties.Resources.adturn;
            this.pictureBox1.Location = new System.Drawing.Point(55, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loading_bar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArdaDDemir";
            this.Load += new System.EventHandler(this.loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loading_bar;
        private System.Windows.Forms.Timer load;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}