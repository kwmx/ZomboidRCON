namespace ZomboidRCON
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.detailsTxt = new System.Windows.Forms.RichTextBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sizeLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailsTxt
            // 
            this.detailsTxt.Location = new System.Drawing.Point(12, 33);
            this.detailsTxt.Name = "detailsTxt";
            this.detailsTxt.Size = new System.Drawing.Size(426, 115);
            this.detailsTxt.TabIndex = 0;
            this.detailsTxt.Text = "";
            this.detailsTxt.TextChanged += new System.EventHandler(this.detailsTxt_TextChanged);
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(12, 15);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(111, 15);
            this.updateLabel.TabIndex = 1;
            this.updateLabel.Text = "New update details:";
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(12, 167);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(426, 38);
            this.downloadBtn.TabIndex = 2;
            this.downloadBtn.Text = "Download and install";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(12, 48);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(426, 23);
            this.downloadBar.TabIndex = 3;
            this.downloadBar.Visible = false;
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(12, 149);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(78, 15);
            this.sizeLbl.TabIndex = 4;
            this.sizeLbl.Text = "Size: xxxx mb";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(402, 149);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(36, 15);
            this.versionLbl.TabIndex = 5;
            this.versionLbl.Text = "vx.y.z";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 217);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.detailsTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.Text = "Update Available";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox detailsTxt;
        private Label updateLabel;
        private Button downloadBtn;
        private ProgressBar downloadBar;
        private ToolTip toolTip1;
        private Label sizeLbl;
        private Label versionLbl;
    }
}