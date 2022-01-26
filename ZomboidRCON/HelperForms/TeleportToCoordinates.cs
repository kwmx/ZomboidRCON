using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZomboidRCON.Models;
using ZomboidRCON.Wrapper;

namespace ZomboidRCON.HelperForms
{
    internal partial class TeleportToCoordinates : Form
    {
        Player player;
        Server server;
        public TeleportToCoordinates(Player player, Server server)
        {
            InitializeComponent();
            this.player = player;
            this.server = server;
        }
        private bool isInt(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int str);
        }
        private void CheckInputUpdate()
        {
            string x = xTxt.Text;
            string y = yTxt.Text;
            string z = zTxt.Text;
            if(isInt(x) && isInt(y) && isInt(z))
            {
                teleportPreviewLabel.Text = "Teleporting to: " + x + " x " + y + " x " + z;
                teleportBtn.Enabled = true;
                previewBtn.Enabled = true;
            }
            else
            {
                teleportPreviewLabel.Text = "Please fill all required coordinate fields for preview";
                teleportBtn.Enabled = false;
                previewBtn.Enabled = false;
            }
        }


        private void TeleportToCoordinates_Load(object sender, EventArgs e)
        {
            Text = "Teleport '" + player.Name + "' to coordinates";
            CheckInputUpdate();
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            string x = xTxt.Text;
            string y = yTxt.Text;
            if (isInt(x) && isInt(y))
            {
                var ps = new ProcessStartInfo("https://map.projectzomboid.com/#" + x + "x" + y)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            
        }

        private async void teleportBtn_Click(object sender, EventArgs e)
        {
            teleportBtn.Enabled = false;
            previewBtn.Enabled = false;
            xTxt.Enabled = false;
            yTxt.Enabled = false;
            zTxt.Enabled = false;
            int x = -1, y = -1, z = -1;
            if(int.TryParse(xTxt.Text, out x) && int.TryParse(yTxt.Text, out y) && int.TryParse(zTxt.Text, out z) && x != -1 && y != -1 && z != -1)
            {
                bool rt = await server.TeleportPlayerToCoordinates(player, x, y, z);
                if (rt) Close();
            } 
            else
            {
                MessageBox.Show("Coordinates conversion failed", "ZomboidRCON");
                xTxt.Text = "";
                yTxt.Text = "";
                zTxt.Text = "";
            }
            xTxt.Enabled = true;
            yTxt.Enabled = true;
            zTxt.Enabled = true;
            CheckInputUpdate();

        }

        private void xTxt_ValueChanged(object sender, EventArgs e)
        {
            CheckInputUpdate();
        }

        private void yTxt_ValueChanged(object sender, EventArgs e)
        {
            CheckInputUpdate();
        }

        private void zTxt_ValueChanged(object sender, EventArgs e)
        {
            CheckInputUpdate();
        }
    }
}
