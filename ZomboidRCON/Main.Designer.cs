namespace ZomboidRCON
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.playerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWhitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teleportToPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godmodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overseerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serverControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.playerMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerMenuStrip
            // 
            this.playerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWhitelistToolStripMenuItem,
            this.teleportToPlayerToolStripMenuItem,
            this.godmodToolStripMenuItem,
            this.accessLevelToolStripMenuItem});
            this.playerMenuStrip.Name = "playerMenuStrip";
            this.playerMenuStrip.Size = new System.Drawing.Size(175, 92);
            // 
            // addToWhitelistToolStripMenuItem
            // 
            this.addToWhitelistToolStripMenuItem.Name = "addToWhitelistToolStripMenuItem";
            this.addToWhitelistToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addToWhitelistToolStripMenuItem.Text = "Add to whitelist";
            // 
            // teleportToPlayerToolStripMenuItem
            // 
            this.teleportToPlayerToolStripMenuItem.Name = "teleportToPlayerToolStripMenuItem";
            this.teleportToPlayerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.teleportToPlayerToolStripMenuItem.Text = "Teleport to player...";
            // 
            // godmodToolStripMenuItem
            // 
            this.godmodToolStripMenuItem.Name = "godmodToolStripMenuItem";
            this.godmodToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.godmodToolStripMenuItem.Text = "Godmod";
            // 
            // accessLevelToolStripMenuItem
            // 
            this.accessLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.overseerToolStripMenuItem,
            this.gMToolStripMenuItem,
            this.moderatorToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.accessLevelToolStripMenuItem.Name = "accessLevelToolStripMenuItem";
            this.accessLevelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.accessLevelToolStripMenuItem.Text = "Set Access Level...";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // overseerToolStripMenuItem
            // 
            this.overseerToolStripMenuItem.Name = "overseerToolStripMenuItem";
            this.overseerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.overseerToolStripMenuItem.Text = "Overseer";
            // 
            // gMToolStripMenuItem
            // 
            this.gMToolStripMenuItem.Name = "gMToolStripMenuItem";
            this.gMToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.gMToolStripMenuItem.Text = "GM";
            // 
            // moderatorToolStripMenuItem
            // 
            this.moderatorToolStripMenuItem.Name = "moderatorToolStripMenuItem";
            this.moderatorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.moderatorToolStripMenuItem.Text = "Moderator";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverControlsToolStripMenuItem,
            this.toolDatabaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(466, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serverControlsToolStripMenuItem
            // 
            this.serverControlsToolStripMenuItem.Name = "serverControlsToolStripMenuItem";
            this.serverControlsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.serverControlsToolStripMenuItem.Text = "Server Controls";
            // 
            // toolDatabaseToolStripMenuItem
            // 
            this.toolDatabaseToolStripMenuItem.Name = "toolDatabaseToolStripMenuItem";
            this.toolDatabaseToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.toolDatabaseToolStripMenuItem.Text = "Tool Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.reportIssueToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessLevelsToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // accessLevelsToolStripMenuItem
            // 
            this.accessLevelsToolStripMenuItem.Name = "accessLevelsToolStripMenuItem";
            this.accessLevelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accessLevelsToolStripMenuItem.Text = "Access Levels";
            this.accessLevelsToolStripMenuItem.Click += new System.EventHandler(this.accessLevelsToolStripMenuItem_Click);
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            this.reportIssueToolStripMenuItem.Click += new System.EventHandler(this.reportIssueToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 391);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackgroundImage = global::ZomboidRCON.Properties.Resources.refreshing;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = global::ZomboidRCON.Properties.Resources.refreshing;
            this.refreshBtn.Location = new System.Drawing.Point(393, 424);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(61, 50);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 486);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Zomboid Admin Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.playerMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTip;
        private ContextMenuStrip playerMenuStrip;
        private ToolStripMenuItem addToWhitelistToolStripMenuItem;
        private ToolStripMenuItem teleportToPlayerToolStripMenuItem;
        private ToolStripMenuItem godmodToolStripMenuItem;
        private ToolStripMenuItem accessLevelToolStripMenuItem;
        private ToolStripMenuItem noneToolStripMenuItem;
        private ToolStripMenuItem overseerToolStripMenuItem;
        private ToolStripMenuItem gMToolStripMenuItem;
        private ToolStripMenuItem moderatorToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private MenuStrip menuStrip;
        private ListView listView1;
        private Button refreshBtn;
        private ToolStripMenuItem serverControlsToolStripMenuItem;
        private ToolStripMenuItem toolDatabaseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem accessLevelsToolStripMenuItem;
        private ToolStripMenuItem reportIssueToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
    }
}