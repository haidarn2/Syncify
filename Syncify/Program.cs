using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Local;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Syncify
{
    static class Program
    {
        const int SERVER_PORT = 40796;

        static SpotifyLocalAPI spotify = new SpotifyLocalAPI();
        static WebSocket client;
        static WebSocketServer server;
        
        static bool init()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Spotify running?: " + SpotifyLocalAPI.IsSpotifyRunning());
            Console.WriteLine("Webhelper running?: " + SpotifyLocalAPI.IsSpotifyWebHelperRunning());
            Console.Write("Connecting to Spotify... ");
            if (spotify.Connect())
            {
                Console.WriteLine("CONNECTED!");
                Console.WriteLine("------------------------------");

                network_wizard(); // server, client initialization
                
                if (server != null)
                {
                    spotify.OnPlayStateChange += Spotify_OnPlayStateChange;
                    spotify.OnTrackChange += Spotify_OnTrackChange;
                    //spotify.OnTrackTimeChange += Spotify_OnTrackTimeChange;
                    //spotify.OnVolumeChange += Spotify_OnVolumeChange;
                    spotify.ListenForEvents = true;
                }
                
                return true;
            }
            Console.WriteLine("CONNECTION FAILED!");
            Console.WriteLine("------------------------------");
            return false;
        }

        private static void network_wizard()
        {
            Console.WriteLine("Press s for Server mode");
            Console.WriteLine("Press c for Client mode");

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.S)
                {
                    server = new WebSocketServer(SERVER_PORT);
                    server.AddWebSocketService<SyncifyWebSocket>("/syncify");
                    server.Start();
                    Console.WriteLine(currentTime() + " Server listening on port " + SERVER_PORT);
                    break;
                }
                else if (key == ConsoleKey.C)
                {
                    Console.Write("Enter Server IP: ");
                    var ip = Console.ReadLine();
                    client = new WebSocket("ws://" + ip + ":" + SERVER_PORT + "/syncify");
                    client.OnOpen += Client_OnOpen;
                    client.OnClose += Client_OnClose;
                    client.OnMessage += Client_OnMessage;
                    client.OnError += Client_OnError;
                    try
                    {
                        client.Connect();
                    }
                    catch(Exception)
                    {
                        
                        // supress connection errors
                    }
                    
                    break;
                }
            }
        }

        // Client Network events

        private static void Client_OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("ERROR CONNECTING TO SERVER.");
        }

        private static void Client_OnMessage(object sender, MessageEventArgs e)
        {
            string data = e.Data;
            switch (data)
            {
                case "PLAY":
                    Console.WriteLine("GOT RESUME SIGNAL FROM SERVER");
                    spotify.Play();
                    break;
                case "PAUSE":
                    Console.WriteLine("GOT PAUSE SIGNAL FROM SERVER");
                    spotify.Pause();
                    break;
                default:
                    Console.WriteLine("GOT CHANGE URI REQUEST: " + data);
                    spotify.PlayURL(data);
                    break;
            }
        }

        private static void Client_OnClose(object sender, CloseEventArgs e)
        {
            Console.WriteLine("Connection to server lost.");
            Console.WriteLine("Reconnecting...");
            client.Connect();
        }

        private static void Client_OnOpen(object sender, EventArgs e)
        {
            Console.WriteLine("Connected to server.");
        }


        // Spotify Events

        private static void Spotify_OnPlayStateChange(PlayStateEventArgs e)
        {
            if (e.Playing)
            {
                Console.WriteLine(currentTime() + " SENDING RESUME SIGNAL TO CLIENTS");
                server.WebSocketServices.Broadcast("PLAY");
            }
            else
            {
                Console.WriteLine(currentTime() + " SENDING PAUSE SIGNAL TO CLIENTS");
                server.WebSocketServices.Broadcast("PAUSE");
            }
                
        }

        private static void Spotify_OnTrackChange(TrackChangeEventArgs e)
        {
            var track = e.NewTrack.TrackResource;
            Console.WriteLine("Track changed: " + track.Name + " by " + e.NewTrack.ArtistResource.Name);
            server.WebSocketServices.Broadcast(track.Uri);
            Console.WriteLine(currentTime() + " SENDING URI TO CLIENTS: " + track.Uri);
        }

        private static void Spotify_OnTrackTimeChange(TrackTimeChangeEventArgs e)
        {
            //Console.WriteLine(e.TrackTime);
            //throw new NotImplementedException();
        }

        private static void Spotify_OnVolumeChange(VolumeChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Handy functions

        static String getSongName()
        {
            SpotifyAPI.Local.Models.Track track = spotify.GetStatus().Track;
            return track.TrackResource.Name;
        }

        static String getArtistName()
        {
            SpotifyAPI.Local.Models.Track track = spotify.GetStatus().Track;
            return track.ArtistResource.Name;
        }

        static String getTrackLength()
        {
            var track = spotify.GetStatus().Track;
            double seconds = track.Length;
            var time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        static String getPosition()
        {
            double seconds = spotify.GetStatus().PlayingPosition;
            var time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        static String getURI()
        {
            var track = spotify.GetStatus().Track;
            return track.TrackResource.Uri;
        }

        static String currentTime()
        {
            return "|" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "|";
        }

        /// <summary>
        /// Seeks to the specified time,
        /// eg seek("1:04")
        /// </summary>
        /// <param name="time"></param>
        static void seek(String time)
        {
            // %23 is the url value for #
            spotify.PlayURL(getURI() + "%23" + time);
            //System.Diagnostics.Process.Start(track.TrackResource.Uri + "#2:50");
        }

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.CursorSize = 15;
            Console.WriteLine("******************************");
            Console.WriteLine("SYNCIFY 0.01 alpha - WIP");
            Console.WriteLine("Created by Nima158");
            Console.WriteLine("December 6, 2015");
            Console.WriteLine("******************************\n");

            if (init())
            {
                //Console.WriteLine("Track name: " + getSongName());
                //Console.WriteLine("Artist: " + getArtistName());
                //Console.WriteLine("Track Length: " + getTrackLength());
                //Console.WriteLine("Position: " + getPosition());
                //seek("1:04");
            }

            while (true)
            {
                // exit after Q key is pressed.
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                    break;
            }

        }
    }
}
