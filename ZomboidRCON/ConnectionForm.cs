using RconSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZomboidRCON.UpdateSystem;
namespace ZomboidRCON
{
    public partial class ConnectionForm : Form
    {
        Main main;
        bool ok = false;
        public ConnectionForm(Main MainForm)
        {
            InitializeComponent();
            main = MainForm;

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            IPAddress? address = null;
            if (!saveBox.Checked)
            {
                Properties.Settings.Default.ip = "";
                Properties.Settings.Default.port = 0;
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(portTxt.Text) || string.IsNullOrEmpty(ipTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show(this, "All fields must be filled", "ZomboidRCON");
                return;
            }
            if (!IPAddress.TryParse(ipTxt.Text, out address))
            {
                try
                {
                    ipTxt.Text = ipTxt.Text.Replace("http://", "").Replace("https://", "").Replace("/", "");
                    address = GetAddressFromUrl(ipTxt.Text);
                    if (address == null) {
                        MessageBox.Show(this, "Couldn't find a valid IP for the provided URL", "ZomboidRCON");
                        return;
                    }
                } catch (Exception exz) {
                    MessageBox.Show(this, "Incorrect IP address: " + exz.Message, "ZomboidRCON");
                    return;
                }
            }
            if (address == null || address.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
            {
                MessageBox.Show(this, "Incorrect IP please enter an IPv4 address", "ZomboidRCON");
                return;
            }
            if (!int.TryParse(portTxt.Text, out int port))
            {
                MessageBox.Show(this, "Incorrect port number", "ZomboidRCON");
                return;
            }
            ipTxt.Enabled = false;
            portTxt.Enabled = false;
            passwordTxt.Enabled = false;
            connectBtn.Enabled = false;
            saveBox.Enabled = false;
            _ = RconConnectAsync(address, port, passwordTxt.Text, ipTxt.Text);
        }
        private async Task RconConnectAsync(IPAddress address, int port, string password, string dbname)
        {
            RconClient client = RconClient.Create(address.ToString(), port);
            try
            {
                await client.ConnectAsync();
                var authenticated = await client.AuthenticateAsync(password);
                if (authenticated)
                {
                    if (saveBox.Checked)
                    {
                        Properties.Settings.Default.ip = address.ToString();
                        Properties.Settings.Default.port = port;
                        Properties.Settings.Default.password = password;
                        Properties.Settings.Default.Save();
                    }

                    main.ResetConnection(client, address.ToString(), port, dbname);
                    main.Show();
                    ok = true;
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show(this, "Authentication issue: Please check your password", "ZomboidRCON");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.Message, "ZomboidRCON");
            }

            ipTxt.Enabled = true;
            portTxt.Enabled = true;
            passwordTxt.Enabled = true;
            connectBtn.Enabled = true;
            saveBox.Enabled = true;
            
        }
        private IPAddress? GetAddressFromUrl(string url)
        {
            if (Uri.CheckHostName(url) == UriHostNameType.Unknown) throw new Exception("Invalid URL");
            Uri uri = new Uri("http://" + url);
            IPHostEntry ihe = Dns.GetHostEntry(uri.Host);
            if(ihe.AddressList.Length > 0)
                foreach(IPAddress ipa in ihe.AddressList)
                {
                    if (ipa.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) return ipa; 
                }
            return null;
        }
        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            ipTxt.Text = String.IsNullOrWhiteSpace(Properties.Settings.Default.ip) ? "" : Properties.Settings.Default.ip;
            portTxt.Text = Properties.Settings.Default.port <= 1023 ? "" : "" + Properties.Settings.Default.port;
            passwordTxt.Text = String.IsNullOrWhiteSpace(Properties.Settings.Default.password) ? "" : Properties.Settings.Default.password;
            saveBox.Checked = !string.IsNullOrEmpty(portTxt.Text) && !string.IsNullOrEmpty(ipTxt.Text) && !string.IsNullOrEmpty(passwordTxt.Text);
        }

        private void ConnectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!ok) Application.Exit();
        }

        private void ipTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
