namespace ZomboidRCON
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.ipLbl = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.saveBox = new System.Windows.Forms.CheckBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(12, 10);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(20, 15);
            this.ipLbl.TabIndex = 0;
            this.ipLbl.Text = "IP:";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 115);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(339, 30);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(78, 7);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(273, 23);
            this.ipTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(78, 65);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(273, 23);
            this.passwordTxt.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 68);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(60, 15);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password:";
            // 
            // saveBox
            // 
            this.saveBox.AutoSize = true;
            this.saveBox.Location = new System.Drawing.Point(143, 94);
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(88, 19);
            this.saveBox.TabIndex = 5;
            this.saveBox.Text = "Save Details";
            this.saveBox.UseVisualStyleBackColor = true;
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(78, 36);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(273, 23);
            this.portTxt.TabIndex = 7;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(12, 39);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(32, 15);
            this.portLbl.TabIndex = 6;
            this.portLbl.Text = "Port:";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 151);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.ipLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionForm";
            this.Text = "Connect to Zomboid RCON server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionForm_FormClosed);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ipLbl;
        private Button connectBtn;
        private TextBox ipTxt;
        private TextBox passwordTxt;
        private Label passwordLbl;
        private CheckBox saveBox;
        private TextBox portTxt;
        private Label portLbl;
    }
}