using SpotifyAPI.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncify_GUI
{
    public partial class MainMenu : Form
    {
        public SpotifyLocalAPI spotify = new SpotifyLocalAPI();
        private ConnectionMenu cm;
        public void consoleWrite(String s)
        {
            var text = DateTime.Now.ToString("|HH:mm:ss| ") + s;
            textBox_console.AppendText(text + Environment.NewLine);

            status_console.Text = "Status: " + s;

            //textBox_console.Lines.Append(text);
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //label_version.Text = Res
            consoleWrite("RENDERING GUI............OK");
            consoleWrite("READY");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //listBox_console.Visible = true;
            var spotify_running = SpotifyLocalAPI.IsSpotifyRunning();
            consoleWrite("Is Spotify running?: " + spotify_running);
            var helper_running = SpotifyLocalAPI.IsSpotifyWebHelperRunning();
            consoleWrite("Is Webhelper running?: " + helper_running);
            if (!spotify_running || !helper_running || !spotify.Connect())
            {
                consoleWrite("ERROR: Please start Spotify");
                SystemSounds.Hand.Play();
                return;
            }
            consoleWrite("Connecting to spotify....OK");
            button_connect_spotify.Enabled = false;
            button_connect_spotify.Text = "Connected to Spotify";
            var old_color = button_connect_spotify.BackColor;
            button_connect_spotify.BackColor = Color.FromArgb(128,173,0);
            
            cm = new ConnectionMenu(this);
            cm.StartPosition = FormStartPosition.Manual;
            cm.Location = new Point(this.Location.X +this.ClientSize.Width, this.Location.Y);
            cm.LocationChanged += Cm_LocationChanged;
            this.LocationChanged += MainMenu_LocationChanged;
            cm.Show(this);
            cm.FormClosed += Cm_FormClosed;
            //cm.
            
            //consoleWrite("Something");
        }

        private void Cm_LocationChanged(object sender, EventArgs e)
        {
            this.Location = new Point(cm.Location.X - this.ClientSize.Width, cm.Location.Y);
        }

        private void MainMenu_LocationChanged(object sender, EventArgs e)
        {
            cm.Location = new Point(this.Location.X + this.ClientSize.Width, this.Location.Y);
        }

        private void Cm_FormClosed(object sender, FormClosedEventArgs e)
        {
            consoleWrite("Disconnected from Spotify");
            button_connect_spotify.Enabled = true;
            button_connect_spotify.Text = "Connect to Spotify";
            button_connect_spotify.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button_about_Click(object sender, EventArgs e)
        {
            //consoleWrite("About button clicked.");
            About about = new About();
            about.Show(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
