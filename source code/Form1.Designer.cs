namespace Beeswarm_timer_v3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.snowBearTimer = new System.Windows.Forms.Timer(this.components);
            this.snowBearTimeDisplay = new System.Windows.Forms.TextBox();
            this.StokingsTimerStart = new System.Windows.Forms.Button();
            this.snowBearTimerStart = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.SstockingsTimeDisplay = new System.Windows.Forms.TextBox();
            this.stockingsTimer = new System.Windows.Forms.Timer(this.components);
            this.snowCanonStart = new System.Windows.Forms.Button();
            this.snowCanonTimeDIsplay = new System.Windows.Forms.TextBox();
            this.snowCanonTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // snowBearTimer
            // 
            this.snowBearTimer.Interval = 1000;
            this.snowBearTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // snowBearTimeDisplay
            // 
            this.snowBearTimeDisplay.Location = new System.Drawing.Point(93, 46);
            this.snowBearTimeDisplay.Name = "snowBearTimeDisplay";
            this.snowBearTimeDisplay.Size = new System.Drawing.Size(100, 20);
            this.snowBearTimeDisplay.TabIndex = 0;
            this.snowBearTimeDisplay.Text = "Time left";
            this.snowBearTimeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.snowBearTimeDisplay.TextChanged += new System.EventHandler(this.snowBearTimeDisplay_TextChanged);
            // 
            // StokingsTimerStart
            // 
            this.StokingsTimerStart.Location = new System.Drawing.Point(12, 14);
            this.StokingsTimerStart.Name = "StokingsTimerStart";
            this.StokingsTimerStart.Size = new System.Drawing.Size(75, 23);
            this.StokingsTimerStart.TabIndex = 1;
            this.StokingsTimerStart.Text = "Stockings";
            this.StokingsTimerStart.UseVisualStyleBackColor = true;
            this.StokingsTimerStart.Click += new System.EventHandler(this.StokingsTimerStart_Click);
            // 
            // snowBearTimerStart
            // 
            this.snowBearTimerStart.Location = new System.Drawing.Point(12, 43);
            this.snowBearTimerStart.Name = "snowBearTimerStart";
            this.snowBearTimerStart.Size = new System.Drawing.Size(75, 23);
            this.snowBearTimerStart.TabIndex = 2;
            this.snowBearTimerStart.Text = "Snowbear";
            this.snowBearTimerStart.UseVisualStyleBackColor = true;
            this.snowBearTimerStart.Click += new System.EventHandler(this.snowBearTimerStart_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(473, 196);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(254, 157);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // SstockingsTimeDisplay
            // 
            this.SstockingsTimeDisplay.Location = new System.Drawing.Point(93, 16);
            this.SstockingsTimeDisplay.Name = "SstockingsTimeDisplay";
            this.SstockingsTimeDisplay.Size = new System.Drawing.Size(100, 20);
            this.SstockingsTimeDisplay.TabIndex = 4;
            this.SstockingsTimeDisplay.Text = "Time left";
            this.SstockingsTimeDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SstockingsTimeDisplay.TextChanged += new System.EventHandler(this.SstockingsTimeDisplay_TextChanged);
            // 
            // stockingsTimer
            // 
            this.stockingsTimer.Interval = 1000;
            this.stockingsTimer.Tick += new System.EventHandler(this.stockingsTimer_Tick);
            // 
            // snowCanonStart
            // 
            this.snowCanonStart.Location = new System.Drawing.Point(12, 72);
            this.snowCanonStart.Name = "snowCanonStart";
            this.snowCanonStart.Size = new System.Drawing.Size(75, 23);
            this.snowCanonStart.TabIndex = 5;
            this.snowCanonStart.Text = "SnowCanon";
            this.snowCanonStart.UseVisualStyleBackColor = true;
            // 
            // snowCanonTimeDIsplay
            // 
            this.snowCanonTimeDIsplay.Location = new System.Drawing.Point(93, 75);
            this.snowCanonTimeDIsplay.Name = "snowCanonTimeDIsplay";
            this.snowCanonTimeDIsplay.Size = new System.Drawing.Size(100, 20);
            this.snowCanonTimeDIsplay.TabIndex = 6;
            this.snowCanonTimeDIsplay.Text = "Time left";
            this.snowCanonTimeDIsplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // snowCanonTimer
            // 
            this.snowCanonTimer.Interval = 1000;
            this.snowCanonTimer.Tick += new System.EventHandler(this.snowCanonTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.snowCanonTimeDIsplay);
            this.Controls.Add(this.snowCanonStart);
            this.Controls.Add(this.SstockingsTimeDisplay);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.snowBearTimerStart);
            this.Controls.Add(this.StokingsTimerStart);
            this.Controls.Add(this.snowBearTimeDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer snowBearTimer;
        private System.Windows.Forms.TextBox snowBearTimeDisplay;
        private System.Windows.Forms.Button StokingsTimerStart;
        private System.Windows.Forms.Button snowBearTimerStart;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox SstockingsTimeDisplay;
        private System.Windows.Forms.Timer stockingsTimer;
        private System.Windows.Forms.Button snowCanonStart;
        private System.Windows.Forms.TextBox snowCanonTimeDIsplay;
        private System.Windows.Forms.Timer snowCanonTimer;
    }
}

