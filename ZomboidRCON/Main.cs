using RconSharp;
using System.Diagnostics;
using ZomboidRCON.Wrapper;

namespace ZomboidRCON
{
    public partial class Main : Form
    {
        private Server server;
        public Main(RconClient clientConnection, string host, int port)
        {
            InitializeComponent();
            server = new Server(clientConnection, host, port);
        }
        public Main()
        {
            InitializeComponent();
        }
        public void ResetConnection(RconClient clientConnection, string host, int port)
        {
            server = new Server(clientConnection, host, port);
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (server == null) Hide();
            ConnectionForm ConnectionForm = new ConnectionForm(this);
            ConnectionForm.Show();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForms.Credits().Show();
            
        }

        private void accessLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InfoForms.AccessLevelInfoForm().Show();
        }

        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ps = new ProcessStartInfo("")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
    }
}