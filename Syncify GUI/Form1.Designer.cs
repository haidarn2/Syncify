namespace Syncify_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_console = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_connect_spotify = new System.Windows.Forms.Button();
            this.picture_title = new System.Windows.Forms.PictureBox();
            this.label_version = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.listBox_console = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_title)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_console});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_console
            // 
            this.status_console.Name = "status_console";
            this.status_console.Size = new System.Drawing.Size(115, 17);
            this.status_console.Text = "Welcome to Syncify!";
            // 
            // button_connect_spotify
            // 
            this.button_connect_spotify.FlatAppearance.BorderSize = 2;
            this.button_connect_spotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect_spotify.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect_spotify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.button_connect_spotify.Location = new System.Drawing.Point(12, 231);
            this.button_connect_spotify.Name = "button_connect_spotify";
            this.button_connect_spotify.Size = new System.Drawing.Size(295, 47);
            this.button_connect_spotify.TabIndex = 1;
            this.button_connect_spotify.Text = "Connect to Spotify";
            this.button_connect_spotify.UseVisualStyleBackColor = true;
            this.button_connect_spotify.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // picture_title
            // 
            this.picture_title.Image = ((System.Drawing.Image)(resources.GetObject("picture_title.Image")));
            this.picture_title.Location = new System.Drawing.Point(0, 12);
            this.picture_title.Name = "picture_title";
            this.picture_title.Size = new System.Drawing.Size(295, 93);
            this.picture_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_title.TabIndex = 2;
            this.picture_title.TabStop = false;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.label_version.Location = new System.Drawing.Point(256, 310);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(63, 18);
            this.label_version.TabIndex = 3;
            this.label_version.Text = "v0.01a";
            this.label_version.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // button_about
            // 
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Gotham Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.button_about.Location = new System.Drawing.Point(12, 284);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 4;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // listBox_console
            // 
            this.listBox_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.listBox_console.Font = new System.Drawing.Font("Courier New", 8F);
            this.listBox_console.FormattingEnabled = true;
            this.listBox_console.ItemHeight = 14;
            this.listBox_console.Items.AddRange(new object[] {
            "**************************************",
            "Syncify v0.01a - WIP",
            "Created by: Nadeem Haidar",
            "github.com/haidarn2/syncify",
            "**************************************"});
            this.listBox_console.Location = new System.Drawing.Point(12, 116);
            this.listBox_console.Name = "listBox_console";
            this.listBox_console.ScrollAlwaysVisible = true;
            this.listBox_console.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_console.Size = new System.Drawing.Size(295, 102);
            this.listBox_console.TabIndex = 5;
            this.listBox_console.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(319, 350);
            this.Controls.Add(this.listBox_console);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.picture_title);
            this.Controls.Add(this.button_connect_spotify);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Syncify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_console;
        private System.Windows.Forms.Button button_connect_spotify;
        private System.Windows.Forms.PictureBox picture_title;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.ListBox listBox_console;
    }
}

