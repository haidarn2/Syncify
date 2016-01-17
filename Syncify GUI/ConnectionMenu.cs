using SpotifyAPI.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Syncify_GUI
{
    public partial class ConnectionMenu : Form
    {
        private const int PORT = 42069;

        private MainMenu mainMenu;
        private WebSocket client;
        private WebSocketServer server;
        private SpotifyLocalAPI spotify;

        private int seconds = 0;

        public ConnectionMenu(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            spotify = mainMenu.spotify;
            InitializeComponent();
        }

        private void ConnectionMenu_Load(object sender, EventArgs e)
        {
            // get IP's for status bar
            var externalip = new System.Net.WebClient().DownloadString("http://bot.whatismyipaddress.com");
            mainMenu.consoleWrite("Found WAN IP: " + externalip);
            var localip = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            if (localip == "")
                localip = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            mainMenu.consoleWrite("Found LAN IP: " + localip);
            status_ip.Text = "WAN: (" + externalip + ") LAN: (" + localip + ")";

            //var process = Process.GetProcessesByName("Spotify");

            mainMenu.consoleWrite("Currently playing: " + getSongName() + " by " + getArtistName());
            pictureBox_album.Image = spotify.GetStatus().Track.GetAlbumArt(SpotifyAPI.Local.Enums.AlbumArtSize.Size640);
            label_song_name.Text = getSongName();
            label_artist_name.Text = getArtistName();
            label_seek_time.Text = getPosition();


            spotify.ListenForEvents = true;
            spotify.OnTrackChange += Spotify_OnTrackChange;
            spotify.OnTrackTimeChange += Spotify_OnTrackTimeChange;
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            
            button_clientmode.Enabled = !button_clientmode.Enabled;
            if (button_clientmode.Enabled)
            {
                // Stop server
                stop_host();
                mainMenu.consoleWrite("Stopping Server..........OK");
                ui_defaults();
            }
            else
            {
                // Start server
                start_host(PORT);
                mainMenu.consoleWrite("Starting server..........OK");
                mainMenu.consoleWrite("Server listening on port " + PORT);
                ui_hostmode();
            }
        }

        private void button_clientmode_Click(object sender, EventArgs e)
        {
            // check if given ip has any blanks
            if (ipAddressControl_client.AnyBlank)
                {
                mainMenu.consoleWrite("ERROR: Please enter a valid IP!");
                SystemSounds.Hand.Play();
                return;
            }

            button_hostmode.Enabled = !button_hostmode.Enabled;
            if (button_hostmode.Enabled)
            {
                // Disconnect from server
                mainMenu.consoleWrite("Disconnecting...");
                stop_client();
                //ui_defaults();
            } 
            else
            {
                // Connect to server
                
                var serverip = ipAddressControl_client.IPAddress;
                mainMenu.consoleWrite("Connecting to " + serverip + "...");
                start_client(serverip.ToString(), PORT);
                //mainMenu.consoleWrite("Connected to " + serverip + ":" + PORT + "!");
                //ui_clientmode();
            }
        }

        // ui modification

        private void ui_defaults()
        {
            button_hostmode.Enabled = true;
            button_hostmode.Text = "Host";
            button_hostmode.BackColor = Color.FromArgb(40, 40, 40);
            button_hostmode.ForeColor = Color.FromArgb(232, 232, 232);

            button_clientmode.Enabled = true;
            button_clientmode.Text = "Connect";
            button_clientmode.BackColor = Color.FromArgb(40, 40, 40);
            button_clientmode.ForeColor = Color.FromArgb(232, 232, 232);
            ipAddressControl_client.Enabled = true;
        }

        private void ui_hostmode()
        {
            button_hostmode.Text = "Stop Hosting";
            button_hostmode.BackColor = Color.FromArgb(128, 173, 0);
            button_hostmode.FlatAppearance.BorderColor = Color.FromArgb(232, 232, 232);
            button_hostmode.ForeColor = Color.FromArgb(44, 57, 0);

            button_clientmode.Text = "Connect disabled";
            button_clientmode.BackColor = Color.FromArgb(50, 50, 50);

            ipAddressControl_client.Enabled = false;
        }

        private void ui_clientmode()
        {
            button_clientmode.Text = "Disconnect";
            button_clientmode.BackColor = Color.FromArgb(128, 173, 0);
            button_clientmode.FlatAppearance.BorderColor = Color.FromArgb(232, 232, 232);
            button_clientmode.ForeColor = Color.FromArgb(44, 57, 0);

            ipAddressControl_client.Enabled = false;

            button_hostmode.Text = "Hosting disabled";
            button_hostmode.BackColor = Color.FromArgb(50, 50, 50);
        }

        // server-client code

        private void start_host(int port)
        {
            server = new WebSocketServer(port);
            server.AddWebSocketService<SyncifyWebSocket>("/syncify");
            server.Start();
        }

        private void stop_host()
        {
            server.Stop();
        }

        private void start_client(string ip, int SERVER_PORT)
        {
            client = new WebSocket("ws://" + ip + ":" + SERVER_PORT + "/syncify");
            client.OnOpen += (sender, e) => {
                mainMenu.consoleWrite("NETWORK: Connection created");
                ui_clientmode();
            };
            client.OnClose += (sender, e) => {
                mainMenu.consoleWrite("NETWORK: Connection closed");
                ui_defaults();
            };
            client.OnMessage += (sender, e) => {
                mainMenu.consoleWrite("NETWORK: MSG FROM SVR: " + e.Data);
                if (e.Data == "PAUSE")
                {
                    spotify.Pause();
                }
                else if (e.Data == "PLAY")
                {
                    spotify.Play();
                }
                else
                {
                    spotify.PlayURL(e.Data);
                } 
            };
            client.OnError += (sender, e) => {
                mainMenu.consoleWrite("NETWORK: ERROR");
            };
            client.Connect();
        }

        private void stop_client()
        {
            client.Close();
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        // spotify listeners

        private void Spotify_OnTrackChange(TrackChangeEventArgs e)
        {
            //var new_image =  spotify.GetStatus().Track.GetAlbumArt(SpotifyAPI.Local.Enums.AlbumArtSize.Size640);
            //string new_name = getSongName();
            //string new_artist = getArtistName();
            
            seconds = 0;
            this.BeginInvoke((Action)delegate ()
            {
                var new_image =  spotify.GetStatus().Track.GetAlbumArt(SpotifyAPI.Local.Enums.AlbumArtSize.Size640);
                string new_name = getSongName();
                string new_artist = getArtistName();
                pictureBox_album.Image = new_image;
                label_song_name.Text = new_name;
                label_artist_name.Text = new_artist;
                mainMenu.consoleWrite("Track changed: " + new_name + " by " + new_artist);
                if (server != null && server.IsListening)
                {
                    server.WebSocketServices.Broadcast(e.NewTrack.TrackResource.Uri);
                    mainMenu.consoleWrite("Broadcasting track change to clients");
                }
            });
            /*
            pictureBox_album.Invoke((MethodInvoker)(() => pictureBox_album.Image = new_image));
            label_song_name.Invoke((MethodInvoker)(() => label_song_name.Text = new_name));
            label_artist_name.Invoke((MethodInvoker)(() => label_artist_name.Text = new_artist));
            this.Invoke((MethodInvoker)delegate
            {
                pictureBox_album.Image = new_image;
                label_song_name.Text = new_name;
                label_artist_name.Text = new_artist;
                mainMenu.consoleWrite("Track changed: " + new_name + " by " + new_artist);
            });  */
        }

        private void Spotify_OnTrackTimeChange(TrackTimeChangeEventArgs e)
        {
            //string new_time = getPosition();
            if (!label_seek_time.IsDisposed && (int) e.TrackTime > seconds)
            {
                seconds = (int) e.TrackTime;
                label_seek_time.Invoke((MethodInvoker)(() => label_seek_time.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss")));
            }
                
        }

        // handy spotify functions

        private String getSongName()
        {
            SpotifyAPI.Local.Models.Track track = spotify.GetStatus().Track;
            return track.TrackResource.Name;
        }

        private string getArtistName()
        {
            SpotifyAPI.Local.Models.Track track = spotify.GetStatus().Track;
            return track.ArtistResource.Name;
        }

        private String getTrackLength()
        {
            var track = spotify.GetStatus().Track;
            double seconds = track.Length;
            var time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        private String getPosition()
        {
            double seconds = spotify.GetStatus().PlayingPosition;
            var time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

    }
}
