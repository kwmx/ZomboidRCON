using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZomboidRCON.Wrapper;

namespace ZomboidRCON.HelperForms
{
    internal partial class CommandConsole : Form
    {
        private Server server;
        public CommandConsole(Server server)
        {
            InitializeComponent();
            this.server = server;
        }
        private void AddToOutput(string title, string content, bool contentNewline = false)
        {
            outputLog.Font = new Font(outputLog.Font, FontStyle.Underline);
            outputLog.ForeColor = Color.Orange;
            outputLog.Text += title + ": " + (contentNewline ? "\n" : "");
            outputLog.Font = new Font(outputLog.Font, FontStyle.Regular);
            outputLog.ForeColor = Color.Black;
            outputLog.Text += content + "\n";

        }
        private void CommandConsole_Load(object sender, EventArgs e)
        {
            AddToOutput("System", "Starting command console");
            commandTxt.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(commandTxt.Text)) sendBtn.Enabled = false;
            else sendBtn.Enabled = true;
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(commandTxt.Text)) return;
            sendBtn.Enabled = false;
            try
            {
                string res = await server.ExecuteCommand(commandTxt.Text);
                AddToOutput("Zomboid RCON Server Response", res, true);
                commandTxt.Text = "";
                commandTxt.Focus();
            }
            catch (TaskCanceledException ex)
            {
                AddToOutput("System", "Execution error, unable to execute command (" + ex.Message + ")");
            }
            sendBtn.Enabled = true;
        }

        private void commandTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && !string.IsNullOrWhiteSpace(commandTxt.Text))

            {
                sendBtn.PerformClick();
            }
        }

        private void outputLog_TextChanged(object sender, EventArgs e)
        {
            outputLog.SelectionStart = outputLog.Text.Length;
            // scroll it automatically
            outputLog.ScrollToCaret();
        }
    }
}
