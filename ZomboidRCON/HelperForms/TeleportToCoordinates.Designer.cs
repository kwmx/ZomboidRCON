namespace ZomboidRCON.HelperForms
{
    partial class TeleportToCoordinates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeleportToCoordinates));
            this.teleportBtn = new System.Windows.Forms.Button();
            this.teleportPreviewLabel = new System.Windows.Forms.Label();
            this.previewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.xTxt = new System.Windows.Forms.NumericUpDown();
            this.yTxt = new System.Windows.Forms.NumericUpDown();
            this.zTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.xTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // teleportBtn
            // 
            this.teleportBtn.Enabled = false;
            this.teleportBtn.Location = new System.Drawing.Point(12, 60);
            this.teleportBtn.Name = "teleportBtn";
            this.teleportBtn.Size = new System.Drawing.Size(362, 23);
            this.teleportBtn.TabIndex = 1;
            this.teleportBtn.Text = "Teleport";
            this.teleportBtn.UseVisualStyleBackColor = true;
            this.teleportBtn.Click += new System.EventHandler(this.teleportBtn_Click);
            // 
            // teleportPreviewLabel
            // 
            this.teleportPreviewLabel.AutoSize = true;
            this.teleportPreviewLabel.Location = new System.Drawing.Point(22, 110);
            this.teleportPreviewLabel.Name = "teleportPreviewLabel";
            this.teleportPreviewLabel.Size = new System.Drawing.Size(92, 15);
            this.teleportPreviewLabel.TabIndex = 2;
            this.teleportPreviewLabel.Text = "Teleport to: x,y,z";
            // 
            // previewBtn
            // 
            this.previewBtn.Enabled = false;
            this.previewBtn.Location = new System.Drawing.Point(12, 128);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(362, 23);
            this.previewBtn.TabIndex = 3;
            this.previewBtn.Text = "Preview in browser";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter coordinates:";
            // 
            // xTxt
            // 
            this.xTxt.Location = new System.Drawing.Point(12, 31);
            this.xTxt.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.xTxt.Name = "xTxt";
            this.xTxt.Size = new System.Drawing.Size(112, 23);
            this.xTxt.TabIndex = 10;
            this.xTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xTxt.ValueChanged += new System.EventHandler(this.xTxt_ValueChanged);
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(147, 31);
            this.yTxt.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.yTxt.Name = "yTxt";
            this.yTxt.Size = new System.Drawing.Size(100, 23);
            this.yTxt.TabIndex = 11;
            this.yTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yTxt.ValueChanged += new System.EventHandler(this.yTxt_ValueChanged);
            // 
            // zTxt
            // 
            this.zTxt.Location = new System.Drawing.Point(272, 31);
            this.zTxt.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.zTxt.Name = "zTxt";
            this.zTxt.Size = new System.Drawing.Size(102, 23);
            this.zTxt.TabIndex = 12;
            this.zTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zTxt.ValueChanged += new System.EventHandler(this.zTxt_ValueChanged);
            // 
            // TeleportToCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 163);
            this.Controls.Add(this.zTxt);
            this.Controls.Add(this.yTxt);
            this.Controls.Add(this.xTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.teleportPreviewLabel);
            this.Controls.Add(this.teleportBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(402, 202);
            this.MinimumSize = new System.Drawing.Size(402, 202);
            this.Name = "TeleportToCoordinates";
            this.Text = "Teleport %player_name% To Coordinates";
            this.Load += new System.EventHandler(this.TeleportToCoordinates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button teleportBtn;
        private Label teleportPreviewLabel;
        private Button previewBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip toolTip1;
        private NumericUpDown xTxt;
        private NumericUpDown yTxt;
        private NumericUpDown zTxt;
    }
}