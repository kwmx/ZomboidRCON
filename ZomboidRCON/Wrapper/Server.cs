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
            dataManager.SetAllPlayersOffline();
            List<Player> players = new List<Player>();
            try
            {
                string response = await client.ExecuteCommandAsync("players");
                string[] arr = response.Split('\n');
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
                        players.Add(player);
                        dataManager.AddPlayer(player);
                    }
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to execute Fetch players command. Try reconnecting", "ZomboidRCON");
            }
            return dataManager.Players;
        }
        public async void AddPlayerToWhiteList(Player player)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("addusertowhitelist " + player.Name);
                MessageBox.Show(response, "ZomboidRCON");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to add player to whitelist. Try reconnecting", "ZomboidRCON");
            }
        }
        public async void ChangePlayerGodmodeStatus(Player player, bool enable)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("godmod " + player.Name + (enable ? " -true" : " -false"));
                MessageBox.Show(response, "ZomboidRCON");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable change godmod on player. Try reconnecting", "ZomboidRCON");
            }
        }
        public async void KickPlayer(Player player)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("kickuser " + player.Name);
                MessageBox.Show(response, "ZomboidRCON");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to kick player. Try reconnecting", "ZomboidRCON");
            }
        }
        public async Task<bool> TeleportToPlayer(Player player, Player toPlayer)
        {
            if (!player.isOnline || !toPlayer.isOnline)
            {
                MessageBox.Show("Both players have to be online, command cannot be executed", "ZomboidRCON");
                return false;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("teleport " + player.Name + " " + toPlayer.Name);
                MessageBox.Show(response, "ZomboidRCON");
                return true;
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to teleport player. Try reconnecting", "ZomboidRCON");
                return false;
            }
        }
        public async Task<bool> TeleportPlayerToCoordinates(Player player, int x, int y, int z)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return false;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("teleportto " + player.Name + " " + x + "," + y + "," + z);
                MessageBox.Show(response, "ZomboidRCON");
                return true;
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to teleport player. Try reconnecting", "ZomboidRCON");
                return false;
            }
        }
        public async Task<bool> SpawnVehicleForPlayer(Player player, Variant variant)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return false;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("addvehicle " + variant.VariantID + " " + player.Name);
                MessageBox.Show(response, "ZomboidRCON");
                return true;
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to teleport player. Try reconnecting", "ZomboidRCON");
                return false;
            }
        }
        public async Task<bool> SpawnVehicleForPlayer(Player player, string vehicleID)
        {
            if (!player.isOnline)
            {
                MessageBox.Show("Player is offline, command cannot be executed", "ZomboidRCON");
                return false;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("addvehicle " + vehicleID + " " + player.Name);
                MessageBox.Show(response, "ZomboidRCON");
                return true;
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to teleport player. Try reconnecting", "ZomboidRCON");
                return false;
            }
        }
        public async void SetAccessLevel(Player player, AccessLevel accessLevel)
        {
            string access = "none";
            switch (accessLevel)
            {
                case AccessLevel.Observer:
                    access = "observer";
                    break;
                case AccessLevel.GM:
                    access = "gm";
                    break;
                case AccessLevel.Overseer:
                    access = "overseer";
                    break;
                case AccessLevel.Moderator:
                    access = "moderator";
                    break;
                case AccessLevel.Admin:
                    access = "admin";
                    break;
                case AccessLevel.None:
                    break;
                case AccessLevel.Unknown:
                    break;
                default:
                    access = "none";
                    break;
            }
            try
            {
                string response = await client.ExecuteCommandAsync("setaccesslevel  " + player.Name + " " + access);
                MessageBox.Show(response, "ZomboidRCON");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Unable to change player's access level. Try reconnecting", "ZomboidRCON");
            }
        }
        public async Task<String> ExecuteCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command)) return "";
            try
            {
                return await client.ExecuteCommandAsync(command);
            }
            catch (TaskCanceledException ece)
            {
                throw ece;
            }
        }
        public void Disconnect()
        {
            client.Disconnect();
        }
        public List<Vehicle> Vehicles { get { return dataManager.Vehicles; } }
        public string Host { get { return host; } }
        public int Port { get { return port; } }
    }
}
