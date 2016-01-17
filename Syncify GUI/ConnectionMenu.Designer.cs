namespace Syncify_GUI
{
    partial class ConnectionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionMenu));
            this.label_host = new System.Windows.Forms.Label();
            this.label_client = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_ip = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_hostmode = new System.Windows.Forms.Button();
            this.button_clientmode = new System.Windows.Forms.Button();
            this.label_or = new System.Windows.Forms.Label();
            this.ipAddressControl_client = new IPAddressControlLib.IPAddressControl();
            this.pictureBox_album = new System.Windows.Forms.PictureBox();
            this.label_song_name = new System.Windows.Forms.Label();
            this.label_artist_name = new System.Windows.Forms.Label();
            this.label_seek_time = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_album)).BeginInit();
            this.SuspendLayout();
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_host.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_host.Location = new System.Drawing.Point(243, 18);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(191, 18);
            this.label_host.TabIndex = 4;
            this.label_host.Text = "Host your own server:";
            // 
            // label_client
            // 
            this.label_client.AutoSize = true;
            this.label_client.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_client.Location = new System.Drawing.Point(243, 193);
            this.label_client.Name = "label_client";
            this.label_client.Size = new System.Drawing.Size(240, 18);
            this.label_client.TabIndex = 5;
            this.label_client.Text = "Connect to an existing host:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_ip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(489, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_ip
            // 
            this.status_ip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.status_ip.Name = "status_ip";
            this.status_ip.Size = new System.Drawing.Size(63, 17);
            this.status_ip.Text = "WAN/LAN";
            // 
            // button_hostmode
            // 
            this.button_hostmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hostmode.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hostmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.button_hostmode.Location = new System.Drawing.Point(246, 53);
            this.button_hostmode.Name = "button_hostmode";
            this.button_hostmode.Size = new System.Drawing.Size(210, 47);
            this.button_hostmode.TabIndex = 7;
            this.button_hostmode.Text = "Host";
            this.button_hostmode.UseVisualStyleBackColor = true;
            this.button_hostmode.Click += new System.EventHandler(this.button_start_server_Click);
            // 
            // button_clientmode
            // 
            this.button_clientmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clientmode.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clientmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.button_clientmode.Location = new System.Drawing.Point(246, 259);
            this.button_clientmode.Name = "button_clientmode";
            this.button_clientmode.Size = new System.Drawing.Size(210, 47);
            this.button_clientmode.TabIndex = 8;
            this.button_clientmode.Text = "Connect";
            this.button_clientmode.UseVisualStyleBackColor = true;
            this.button_clientmode.Click += new System.EventHandler(this.button_clientmode_Click);
            // 
            // label_or
            // 
            this.label_or.AutoSize = true;
            this.label_or.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_or.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_or.Location = new System.Drawing.Point(335, 147);
            this.label_or.Name = "label_or";
            this.label_or.Size = new System.Drawing.Size(34, 18);
            this.label_or.TabIndex = 9;
            this.label_or.Text = "OR";
            // 
            // ipAddressControl_client
            // 
            this.ipAddressControl_client.AllowInternalTab = false;
            this.ipAddressControl_client.AutoHeight = true;
            this.ipAddressControl_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ipAddressControl_client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipAddressControl_client.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressControl_client.Location = new System.Drawing.Point(246, 227);
            this.ipAddressControl_client.MinimumSize = new System.Drawing.Size(124, 26);
            this.ipAddressControl_client.Name = "ipAddressControl_client";
            this.ipAddressControl_client.ReadOnly = false;
            this.ipAddressControl_client.Size = new System.Drawing.Size(210, 26);
            this.ipAddressControl_client.TabIndex = 11;
            this.ipAddressControl_client.Text = "...";
            // 
            // pictureBox_album
            // 
            this.pictureBox_album.Location = new System.Drawing.Point(12, 18);
            this.pictureBox_album.Name = "pictureBox_album";
            this.pictureBox_album.Size = new System.Drawing.Size(225, 214);
            this.pictureBox_album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_album.TabIndex = 14;
            this.pictureBox_album.TabStop = false;
            // 
            // label_song_name
            // 
            this.label_song_name.AutoEllipsis = true;
            this.label_song_name.AutoSize = true;
            this.label_song_name.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_song_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_song_name.Location = new System.Drawing.Point(12, 235);
            this.label_song_name.MaximumSize = new System.Drawing.Size(295, 18);
            this.label_song_name.Name = "label_song_name";
            this.label_song_name.Size = new System.Drawing.Size(102, 18);
            this.label_song_name.TabIndex = 15;
            this.label_song_name.Text = "song_name";
            // 
            // label_artist_name
            // 
            this.label_artist_name.AutoSize = true;
            this.label_artist_name.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_artist_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_artist_name.Location = new System.Drawing.Point(12, 253);
            this.label_artist_name.Name = "label_artist_name";
            this.label_artist_name.Size = new System.Drawing.Size(105, 18);
            this.label_artist_name.TabIndex = 16;
            this.label_artist_name.Text = "artist_name";
            // 
            // label_seek_time
            // 
            this.label_seek_time.AutoSize = true;
            this.label_seek_time.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_seek_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_seek_time.Location = new System.Drawing.Point(12, 287);
            this.label_seek_time.Name = "label_seek_time";
            this.label_seek_time.Size = new System.Drawing.Size(92, 18);
            this.label_seek_time.TabIndex = 17;
            this.label_seek_time.Text = "seek_time";
            // 
            // ConnectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(489, 350);
            this.Controls.Add(this.label_seek_time);
            this.Controls.Add(this.label_artist_name);
            this.Controls.Add(this.label_song_name);
            this.Controls.Add(this.pictureBox_album);
            this.Controls.Add(this.ipAddressControl_client);
            this.Controls.Add(this.label_or);
            this.Controls.Add(this.button_clientmode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_client);
            this.Controls.Add(this.label_host);
            this.Controls.Add(this.button_hostmode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionMenu";
            this.ShowInTaskbar = false;
            this.Text = "Network connection";
            this.Load += new System.EventHandler(this.ConnectionMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_album)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Label label_client;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_ip;
        private System.Windows.Forms.Button button_hostmode;
        private System.Windows.Forms.Button button_clientmode;
        private System.Windows.Forms.Label label_or;
        private IPAddressControlLib.IPAddressControl ipAddressControl_client;
        private System.Windows.Forms.PictureBox pictureBox_album;
        private System.Windows.Forms.Label label_song_name;
        private System.Windows.Forms.Label label_artist_name;
        private System.Windows.Forms.Label label_seek_time;
    }
}