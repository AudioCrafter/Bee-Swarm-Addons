namespace Beeswarm_timer_v3
{
    partial class Form3
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
            this.TopBarLabel = new System.Windows.Forms.Label();
            this.ReleaseVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatedByBobiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopBarLabel
            // 
            this.TopBarLabel.AutoSize = true;
            this.TopBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TopBarLabel.Location = new System.Drawing.Point(21, 9);
            this.TopBarLabel.Name = "TopBarLabel";
            this.TopBarLabel.Size = new System.Drawing.Size(177, 25);
            this.TopBarLabel.TabIndex = 0;
            this.TopBarLabel.Text = "Beeswarm Addons";
            this.TopBarLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReleaseVersion
            // 
            this.ReleaseVersion.AutoSize = true;
            this.ReleaseVersion.Location = new System.Drawing.Point(72, 34);
            this.ReleaseVersion.Name = "ReleaseVersion";
            this.ReleaseVersion.Size = new System.Drawing.Size(73, 13);
            this.ReleaseVersion.TabIndex = 1;
            this.ReleaseVersion.Text = "Release 1.3.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sounds Created with";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(156, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "15.ai";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // CreatedByBobiLabel
            // 
            this.CreatedByBobiLabel.AutoSize = true;
            this.CreatedByBobiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CreatedByBobiLabel.Location = new System.Drawing.Point(60, 117);
            this.CreatedByBobiLabel.Name = "CreatedByBobiLabel";
            this.CreatedByBobiLabel.Size = new System.Drawing.Size(101, 13);
            this.CreatedByBobiLabel.TabIndex = 4;
            this.CreatedByBobiLabel.Text = "Code by Bobi#8025";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 139);
            this.Controls.Add(this.CreatedByBobiLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReleaseVersion);
            this.Controls.Add(this.TopBarLabel);
            this.Name = "Form3";
            this.Text = "About";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopBarLabel;
        private System.Windows.Forms.Label ReleaseVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CreatedByBobiLabel;
    }
}