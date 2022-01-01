namespace Beeswarm_timer_v3
{
    partial class settingswindow
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonColseSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColseSettings
            // 
            this.buttonColseSettings.Location = new System.Drawing.Point(468, 462);
            this.buttonColseSettings.Name = "buttonColseSettings";
            this.buttonColseSettings.Size = new System.Drawing.Size(95, 23);
            this.buttonColseSettings.TabIndex = 0;
            this.buttonColseSettings.Text = "Save / Back";
            this.buttonColseSettings.UseVisualStyleBackColor = true;
            this.buttonColseSettings.Click += new System.EventHandler(this.buttonColseSettings_Click);
            // 
            // settingswindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonColseSettings);
            this.Name = "settingswindow";
            this.Size = new System.Drawing.Size(566, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonColseSettings;
    }
}
