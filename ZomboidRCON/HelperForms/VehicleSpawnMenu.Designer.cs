namespace ZomboidRCON.HelperForms
{
    partial class VehicleSpawnMenu
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
            this.vehicleImage = new System.Windows.Forms.PictureBox();
            this.vehiclesCombo = new System.Windows.Forms.ComboBox();
            this.variantCombo = new System.Windows.Forms.ComboBox();
            this.spawnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleImage
            // 
            this.vehicleImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleImage.ErrorImage = global::ZomboidRCON.Properties.Resources.empty;
            this.vehicleImage.Image = global::ZomboidRCON.Properties.Resources.empty;
            this.vehicleImage.InitialImage = global::ZomboidRCON.Properties.Resources.empty;
            this.vehicleImage.Location = new System.Drawing.Point(12, 12);
            this.vehicleImage.Name = "vehicleImage";
            this.vehicleImage.Size = new System.Drawing.Size(218, 191);
            this.vehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vehicleImage.TabIndex = 0;
            this.vehicleImage.TabStop = false;
            // 
            // vehiclesCombo
            // 
            this.vehiclesCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclesCombo.FormattingEnabled = true;
            this.vehiclesCombo.Location = new System.Drawing.Point(236, 47);
            this.vehiclesCombo.Name = "vehiclesCombo";
            this.vehiclesCombo.Size = new System.Drawing.Size(321, 23);
            this.vehiclesCombo.TabIndex = 1;
            this.vehiclesCombo.SelectedIndexChanged += new System.EventHandler(this.vehiclesCombo_SelectedIndexChanged);
            // 
            // variantCombo
            // 
            this.variantCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variantCombo.FormattingEnabled = true;
            this.variantCombo.Location = new System.Drawing.Point(236, 111);
            this.variantCombo.Name = "variantCombo";
            this.variantCombo.Size = new System.Drawing.Size(321, 23);
            this.variantCombo.TabIndex = 2;
            this.variantCombo.SelectedIndexChanged += new System.EventHandler(this.variantCombo_SelectedIndexChanged);
            // 
            // spawnBtn
            // 
            this.spawnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spawnBtn.Location = new System.Drawing.Point(236, 179);
            this.spawnBtn.Name = "spawnBtn";
            this.spawnBtn.Size = new System.Drawing.Size(321, 23);
            this.spawnBtn.TabIndex = 3;
            this.spawnBtn.Text = "Spawn";
            this.spawnBtn.UseVisualStyleBackColor = true;
            this.spawnBtn.Click += new System.EventHandler(this.spawnBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehicle Model:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Variant:";
            // 
            // VehicleSpawnMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spawnBtn);
            this.Controls.Add(this.variantCombo);
            this.Controls.Add(this.vehiclesCombo);
            this.Controls.Add(this.vehicleImage);
            this.MaximumSize = new System.Drawing.Size(1056, 715);
            this.MinimumSize = new System.Drawing.Size(585, 253);
            this.Name = "VehicleSpawnMenu";
            this.Text = "VehicleSpawnMenu";
            this.Load += new System.EventHandler(this.VehicleSpawnMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox vehicleImage;
        private ComboBox vehiclesCombo;
        private ComboBox variantCombo;
        private Button spawnBtn;
        private Label label1;
        private Label label2;
    }
}