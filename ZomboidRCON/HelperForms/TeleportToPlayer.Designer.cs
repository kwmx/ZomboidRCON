namespace ZomboidRCON.HelperForms
{
    partial class TeleportToPlayer
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.playersCombo = new System.Windows.Forms.ComboBox();
            this.teleportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(173, 15);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Teleporting %player_name% to:";
            // 
            // playersCombo
            // 
            this.playersCombo.FormattingEnabled = true;
            this.playersCombo.Location = new System.Drawing.Point(12, 36);
            this.playersCombo.Name = "playersCombo";
            this.playersCombo.Size = new System.Drawing.Size(430, 23);
            this.playersCombo.TabIndex = 1;
            this.playersCombo.SelectedIndexChanged += new System.EventHandler(this.playersCombo_SelectedIndexChanged);
            // 
            // teleportBtn
            // 
            this.teleportBtn.Enabled = false;
            this.teleportBtn.Location = new System.Drawing.Point(12, 67);
            this.teleportBtn.Name = "teleportBtn";
            this.teleportBtn.Size = new System.Drawing.Size(430, 23);
            this.teleportBtn.TabIndex = 2;
            this.teleportBtn.Text = "Teleport";
            this.teleportBtn.UseVisualStyleBackColor = true;
            this.teleportBtn.Click += new System.EventHandler(this.teleportBtn_Click);
            // 
            // TeleportToPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 102);
            this.Controls.Add(this.teleportBtn);
            this.Controls.Add(this.playersCombo);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(470, 141);
            this.MinimumSize = new System.Drawing.Size(470, 141);
            this.Name = "TeleportToPlayer";
            this.Text = "TeleportToPlayer";
            this.Load += new System.EventHandler(this.TeleportToPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label infoLabel;
        private ComboBox playersCombo;
        private Button teleportBtn;
    }
}