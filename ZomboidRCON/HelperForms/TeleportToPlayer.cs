using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZomboidRCON.Models;
using ZomboidRCON.Wrapper;

namespace ZomboidRCON.HelperForms
{
    internal partial class TeleportToPlayer : Form
    {
        List<Player> players;
        Player player;
        Server server;
        public TeleportToPlayer(Player player, Server server)
        {
            InitializeComponent();
            this.player = player;
            this.server = server;
        }

        private async void TeleportToPlayer_Load(object sender, EventArgs e)
        {
            Text = "Teleport '" + player.Name + "' to another player";
            teleportBtn.Enabled = false;
            playersCombo.Enabled = false;
            infoLabel.Text = infoLabel.Text.Replace("%player_name%", player.Name);
            players = await server.GetPlayers();
            foreach(Player p in players)
            {
                if (p.Name == player.Name) continue;
                playersCombo.Items.Add(p.Name);
            }
            playersCombo.Enabled = true;
        }

        private void playersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(playersCombo.Text) || playersCombo.SelectedIndex < 0)
            {
                teleportBtn.Enabled = false;
            }
            else
            {
                teleportBtn.Enabled = true;
            }

        }

        private async void teleportBtn_Click(object sender, EventArgs e)
        {
            teleportBtn.Enabled = false;
            playersCombo.Enabled = false;
            bool rt = await server.TeleportToPlayer(player, player);
            if (rt) Close();
            playersCombo.Enabled = true;
        }
    }
}
