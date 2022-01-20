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
using ZomboidRCON.Properties;
using ZomboidRCON.Wrapper;

namespace ZomboidRCON.HelperForms
{
    internal partial class VehicleSpawnMenu : Form
    {
        List<Vehicle> vehicles;
        Player player;
        Server server;

        public VehicleSpawnMenu(Player player, Server server)
        {
            InitializeComponent();
            this.player = player;
            this.server = server;
        }

        private void VehicleSpawnMenu_Load(object sender, EventArgs e)
        {
            Text = "Spawn a vehicle for '" + player.Name + "'";
            vehicles = server.Vehicles;
            for(int i = 0; i < vehicles.Count; i++)
            {
                vehiclesCombo.Items.Add(vehicles[i].Name);
            }
            variantCombo.Enabled = false;
            spawnBtn.Enabled = false;
        }

        private void vehiclesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = vehiclesCombo.SelectedIndex;
            variantCombo.Items.Clear();
            variantCombo.Enabled = false;
            if (i != -1 && vehicles[i].Variants != null)
            {
                for(int j = 0; j < vehicles[i].Variants.Length; j++)
                {
                    variantCombo.Items.Add(vehicles[i].Variants[j].Title);
                }
                if(variantCombo.Items.Count > 0) variantCombo.SelectedIndex = 0;
                variantCombo.Enabled = true;
            }
        }

        private void variantCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = vehiclesCombo.SelectedIndex;
            int j = variantCombo.SelectedIndex;
            if (i != -1 && vehicles[i].Variants != null)
            {
                if(vehicles[i].Variants[j].isStock)
                {
                    vehicleImage.Image = (Image)Resources.ResourceManager.GetObject(vehicles[i].Variants[j].VariantID);
                }
                spawnBtn.Enabled = true;
            }
            else
            {
                spawnBtn.Enabled = false;
            }
        }

        private async void spawnBtn_Click(object sender, EventArgs e)
        {
            spawnBtn.Enabled = false;
            int i = vehiclesCombo.SelectedIndex;
            int j = variantCombo.SelectedIndex;
            if (i >= 0 && j >= 0 && vehicles[i].Variants != null && vehicles[i].Variants[j] != null)
            {
                vehiclesCombo.Enabled = false;
                variantCombo.Enabled = false;
                bool rt = await server.SpawnVehicleForPlayer(player, vehicles[i].Variants[j]);
                if(rt) Close();
                vehiclesCombo.Enabled = true;
                variantCombo.Enabled = true;
            }

        }
    }
}
