namespace ZomboidRCON.HelperForms
{
    partial class CommandConsole
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
            this.outputLog = new System.Windows.Forms.RichTextBox();
            this.commandTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLog
            // 
            this.outputLog.Location = new System.Drawing.Point(12, 12);
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.Size = new System.Drawing.Size(776, 397);
            this.outputLog.TabIndex = 0;
            this.outputLog.Text = "";
            this.outputLog.TextChanged += new System.EventHandler(this.outputLog_TextChanged);
            // 
            // commandTxt
            // 
            this.commandTxt.Location = new System.Drawing.Point(12, 415);
            this.commandTxt.Name = "commandTxt";
            this.commandTxt.Size = new System.Drawing.Size(702, 23);
            this.commandTxt.TabIndex = 1;
            this.commandTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.commandTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandTxt_KeyPress);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(720, 415);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(68, 23);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // CommandConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.commandTxt);
            this.Controls.Add(this.outputLog);
            this.Name = "CommandConsole";
            this.Text = "Command Console";
            this.Load += new System.EventHandler(this.CommandConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox outputLog;
        private TextBox commandTxt;
        private Button sendBtn;
    }
}