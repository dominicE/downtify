namespace Downtify.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDownload = new System.Windows.Forms.Button();
            this.TrackList = new System.Windows.Forms.ListView();
            this.progressBar1 = new Downtify.GUI.TextProgressBar();
            this.textBoxLink = new Downtify.GUI.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Location = new System.Drawing.Point(399, 315);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(106, 23);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // TrackList
            // 
            this.TrackList.Location = new System.Drawing.Point(12, 40);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(493, 269);
            this.TrackList.TabIndex = 4;
            this.TrackList.UseCompatibleStateImageBehavior = false;
            this.TrackList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrackList_KeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.CurrentTrack = 0;
            this.progressBar1.Location = new System.Drawing.Point(12, 315);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ShowText = false;
            this.progressBar1.Size = new System.Drawing.Size(381, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.TotalTracks = 0;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(12, 12);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Placeholder = "Put your track or playlist link here";
            this.textBoxLink.Size = new System.Drawing.Size(493, 22);
            this.textBoxLink.TabIndex = 1;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downtify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Downtify.GUI.PlaceholderTextBox textBoxLink;
        private System.Windows.Forms.Button buttonDownload;
        private Downtify.GUI.TextProgressBar progressBar1;
        private System.Windows.Forms.ListView TrackList;
    }
}

