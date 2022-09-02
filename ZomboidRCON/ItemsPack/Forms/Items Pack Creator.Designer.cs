namespace ZomboidRCON.ItemsPack.Forms
{
    partial class ItemsPackCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsPackCreator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.packageInfo = new System.Windows.Forms.TabPage();
            this.packageItems = new System.Windows.Forms.TabPage();
            this.packageVehicles = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.packageInfo);
            this.tabControl1.Controls.Add(this.packageItems);
            this.tabControl1.Controls.Add(this.packageVehicles);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // packageInfo
            // 
            this.packageInfo.Location = new System.Drawing.Point(4, 24);
            this.packageInfo.Name = "packageInfo";
            this.packageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.packageInfo.Size = new System.Drawing.Size(731, 441);
            this.packageInfo.TabIndex = 0;
            this.packageInfo.Text = "Package Information";
            this.packageInfo.UseVisualStyleBackColor = true;
            // 
            // packageItems
            // 
            this.packageItems.Location = new System.Drawing.Point(4, 24);
            this.packageItems.Name = "packageItems";
            this.packageItems.Padding = new System.Windows.Forms.Padding(3);
            this.packageItems.Size = new System.Drawing.Size(731, 441);
            this.packageItems.TabIndex = 1;
            this.packageItems.Text = "Items";
            this.packageItems.UseVisualStyleBackColor = true;
            // 
            // packageVehicles
            // 
            this.packageVehicles.Location = new System.Drawing.Point(4, 24);
            this.packageVehicles.Name = "packageVehicles";
            this.packageVehicles.Size = new System.Drawing.Size(731, 441);
            this.packageVehicles.TabIndex = 2;
            this.packageVehicles.Text = "Vehicles";
            this.packageVehicles.UseVisualStyleBackColor = true;
            // 
            // ItemsPackCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 541);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemsPackCreator";
            this.Text = "Items Pack Creator";
            this.Load += new System.EventHandler(this.ItemsPackCreator_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage packageInfo;
        private TabPage packageItems;
        private TabPage packageVehicles;
    }
}