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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online Player", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline Players", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.playerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWhitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teleportToPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godmodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overseerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.spawnVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spawnItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kickPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serverControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAndChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersView = new System.Windows.Forms.ListView();
            this.nameCol = new System.Windows.Forms.ColumnHeader();
            this.accessCol = new System.Windows.Forms.ColumnHeader();
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
            this.accessLevelToolStripMenuItem,
            this.toolStripSeparator1,
            this.spawnVehicleToolStripMenuItem,
            this.spawnItemToolStripMenuItem,
            this.toolStripSeparator2,
            this.kickPlayerToolStripMenuItem});
            this.playerMenuStrip.Name = "playerMenuStrip";
            this.playerMenuStrip.Size = new System.Drawing.Size(175, 170);
            this.playerMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.playerMenuStrip_Opening);
            this.playerMenuStrip.Opened += new System.EventHandler(this.playerMenuStrip_Opened);
            // 
            // addToWhitelistToolStripMenuItem
            // 
            this.addToWhitelistToolStripMenuItem.Name = "addToWhitelistToolStripMenuItem";
            this.addToWhitelistToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addToWhitelistToolStripMenuItem.Text = "Add to whitelist";
            this.addToWhitelistToolStripMenuItem.Click += new System.EventHandler(this.addToWhitelistToolStripMenuItem_Click);
            // 
            // teleportToPlayerToolStripMenuItem
            // 
            this.teleportToPlayerToolStripMenuItem.Name = "teleportToPlayerToolStripMenuItem";
            this.teleportToPlayerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.teleportToPlayerToolStripMenuItem.Text = "Teleport to player...";
            this.teleportToPlayerToolStripMenuItem.Click += new System.EventHandler(this.teleportToPlayerToolStripMenuItem_Click);
            // 
            // godmodToolStripMenuItem
            // 
            this.godmodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.godmodToolStripMenuItem.Name = "godmodToolStripMenuItem";
            this.godmodToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.godmodToolStripMenuItem.Text = "Godmod";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
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
            this.accessLevelToolStripMenuItem.Text = "Set Access Level";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // overseerToolStripMenuItem
            // 
            this.overseerToolStripMenuItem.Name = "overseerToolStripMenuItem";
            this.overseerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.overseerToolStripMenuItem.Text = "Overseer";
            this.overseerToolStripMenuItem.Click += new System.EventHandler(this.overseerToolStripMenuItem_Click);
            // 
            // gMToolStripMenuItem
            // 
            this.gMToolStripMenuItem.Name = "gMToolStripMenuItem";
            this.gMToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.gMToolStripMenuItem.Text = "GM";
            this.gMToolStripMenuItem.Click += new System.EventHandler(this.gMToolStripMenuItem_Click);
            // 
            // moderatorToolStripMenuItem
            // 
            this.moderatorToolStripMenuItem.Name = "moderatorToolStripMenuItem";
            this.moderatorToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.moderatorToolStripMenuItem.Text = "Moderator";
            this.moderatorToolStripMenuItem.Click += new System.EventHandler(this.moderatorToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // spawnVehicleToolStripMenuItem
            // 
            this.spawnVehicleToolStripMenuItem.Name = "spawnVehicleToolStripMenuItem";
            this.spawnVehicleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.spawnVehicleToolStripMenuItem.Text = "Spawn Vehicle...";
            this.spawnVehicleToolStripMenuItem.Click += new System.EventHandler(this.spawnVehicleToolStripMenuItem_Click);
            // 
            // spawnItemToolStripMenuItem
            // 
            this.spawnItemToolStripMenuItem.Enabled = false;
            this.spawnItemToolStripMenuItem.Name = "spawnItemToolStripMenuItem";
            this.spawnItemToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.spawnItemToolStripMenuItem.Text = "Spawn Item...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // kickPlayerToolStripMenuItem
            // 
            this.kickPlayerToolStripMenuItem.Name = "kickPlayerToolStripMenuItem";
            this.kickPlayerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kickPlayerToolStripMenuItem.Text = "Kick Player";
            this.kickPlayerToolStripMenuItem.Click += new System.EventHandler(this.kickPlayerToolStripMenuItem_Click);
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
            this.serverControlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandConsoleToolStripMenuItem,
            this.serverOptionToolStripMenuItem});
            this.serverControlsToolStripMenuItem.Name = "serverControlsToolStripMenuItem";
            this.serverControlsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.serverControlsToolStripMenuItem.Text = "Server Controls";
            // 
            // commandConsoleToolStripMenuItem
            // 
            this.commandConsoleToolStripMenuItem.Name = "commandConsoleToolStripMenuItem";
            this.commandConsoleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.commandConsoleToolStripMenuItem.Text = "Command Console";
            this.commandConsoleToolStripMenuItem.Click += new System.EventHandler(this.commandConsoleToolStripMenuItem_Click);
            // 
            // serverOptionToolStripMenuItem
            // 
            this.serverOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAndChangeToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.serverOptionToolStripMenuItem.Enabled = false;
            this.serverOptionToolStripMenuItem.Name = "serverOptionToolStripMenuItem";
            this.serverOptionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.serverOptionToolStripMenuItem.Text = "Server Option";
            // 
            // viewAndChangeToolStripMenuItem
            // 
            this.viewAndChangeToolStripMenuItem.Enabled = false;
            this.viewAndChangeToolStripMenuItem.Name = "viewAndChangeToolStripMenuItem";
            this.viewAndChangeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewAndChangeToolStripMenuItem.Text = "View and change";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Enabled = false;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // toolDatabaseToolStripMenuItem
            // 
            this.toolDatabaseToolStripMenuItem.Enabled = false;
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
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // accessLevelsToolStripMenuItem
            // 
            this.accessLevelsToolStripMenuItem.Name = "accessLevelsToolStripMenuItem";
            this.accessLevelsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.accessLevelsToolStripMenuItem.Text = "Access Levels";
            this.accessLevelsToolStripMenuItem.Click += new System.EventHandler(this.accessLevelsToolStripMenuItem_Click);
            // 
            // reportIssueToolStripMenuItem
            // 
            this.reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            this.reportIssueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reportIssueToolStripMenuItem.Text = "Report Issue";
            this.reportIssueToolStripMenuItem.Click += new System.EventHandler(this.reportIssueToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // playersView
            // 
            this.playersView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.accessCol});
            this.playersView.ContextMenuStrip = this.playerMenuStrip;
            listViewGroup1.Header = "Online Player";
            listViewGroup1.Name = "OnlinePlayers";
            listViewGroup2.Header = "Offline Players";
            listViewGroup2.Name = "OfflinePlayers";
            this.playersView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.playersView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.playersView.Location = new System.Drawing.Point(12, 27);
            this.playersView.MultiSelect = false;
            this.playersView.Name = "playersView";
            this.playersView.Size = new System.Drawing.Size(442, 391);
            this.playersView.TabIndex = 3;
            this.playersView.UseCompatibleStateImageBehavior = false;
            this.playersView.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Player Name";
            this.nameCol.Width = 200;
            // 
            // accessCol
            // 
            this.accessCol.Text = "Access Level";
            this.accessCol.Width = 120;
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
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 486);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.playersView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Zomboid Admin Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
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
        private ListView playersView;
        private Button refreshBtn;
        private ToolStripMenuItem serverControlsToolStripMenuItem;
        private ToolStripMenuItem toolDatabaseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem accessLevelsToolStripMenuItem;
        private ToolStripMenuItem reportIssueToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ColumnHeader nameCol;
        private ColumnHeader accessCol;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem kickPlayerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem commandConsoleToolStripMenuItem;
        private ToolStripMenuItem serverOptionToolStripMenuItem;
        private ToolStripMenuItem viewAndChangeToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem spawnVehicleToolStripMenuItem;
        private ToolStripMenuItem spawnItemToolStripMenuItem;
    }
}