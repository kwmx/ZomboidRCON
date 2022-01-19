using RconSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZomboidRCON.Models;

namespace ZomboidRCON.Wrapper
{
    internal class Server
    {
        private DataManager dataManager;
        private RconClient client;
        private string host;
        private int port;
        public Server(RconClient client, string host, int port)
        {
            this.client = client;
            this.host = host;
            this.port = port;
            dataManager = new DataManager(host.Replace(".", "") + port + "_db");
            _ = GetPlayers();
        }
        public async Task<List<Player>> GetPlayers()
        {
            List<Player> players = new List<Player>();
            try
            {
                string response = await client.ExecuteCommandAsync("players");
                string[] arr = response.Split('\n');
                List<Player> list = new List<Player>();
                foreach (string item in arr)
                {
                    if (item.StartsWith('-'))
                    {
                        string user = item.Substring(1);
                        Player player = new Player {
                            Name = user,
                            isOnline = true,
                            accessLevel =  AccessLevel.Unknown,
                        };
                        list.Add(player);
                    }
                }
                dataManager.AddPlayer(list);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to execute Fetch players command. Try reconnecting", "ZomboidRCON");
            }
            return players;
        }
        public List<Vehicle> Vehicles { get { return dataManager.Vehicles; } }
        public string Host { get { return host; } }
        public int Port { get { return port; } }
    }
}
