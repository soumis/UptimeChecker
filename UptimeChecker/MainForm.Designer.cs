namespace UptimeChecker
{
    partial class MainForm
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
            this.txtboxConsole = new System.Windows.Forms.TextBox();
            this.backgroundWorkerUptime = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtboxConsole
            // 
            this.txtboxConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtboxConsole.Location = new System.Drawing.Point(12, 25);
            this.txtboxConsole.Multiline = true;
            this.txtboxConsole.Name = "txtboxConsole";
            this.txtboxConsole.ReadOnly = true;
            this.txtboxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxConsole.Size = new System.Drawing.Size(790, 413);
            this.txtboxConsole.TabIndex = 0;
            // 
            // backgroundWorkerUptime
            // 
            this.backgroundWorkerUptime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUptime_DoWork);
            this.backgroundWorkerUptime.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUptime_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxConsole);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uptime Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUptime;
    }
}

