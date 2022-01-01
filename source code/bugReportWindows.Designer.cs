namespace Beeswarm_timer_v3
{
    partial class bugReportWindows
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
            this.FoundAbug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscordLink = new System.Windows.Forms.Label();
            this.TwitterLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FoundAbug
            // 
            this.FoundAbug.AutoSize = true;
            this.FoundAbug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FoundAbug.Location = new System.Drawing.Point(12, 9);
            this.FoundAbug.Name = "FoundAbug";
            this.FoundAbug.Size = new System.Drawing.Size(135, 51);
            this.FoundAbug.TabIndex = 0;
            this.FoundAbug.Text = "Found a bug?\r\nimprovement ideas?\r\nlet me know:";
            this.FoundAbug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoundAbug.Click += new System.EventHandler(this.FoundAbug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discord:\r\n\r\nTwitter:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thank you!";
            // 
            // DiscordLink
            // 
            this.DiscordLink.AutoSize = true;
            this.DiscordLink.Location = new System.Drawing.Point(65, 75);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(59, 13);
            this.DiscordLink.TabIndex = 3;
            this.DiscordLink.Text = "Bobi#8025";
            this.DiscordLink.Click += new System.EventHandler(this.DiscordLink_Click);
            this.DiscordLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiscordLink_MouseClick);
            // 
            // TwitterLink
            // 
            this.TwitterLink.AutoSize = true;
            this.TwitterLink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TwitterLink.Location = new System.Drawing.Point(61, 101);
            this.TwitterLink.Name = "TwitterLink";
            this.TwitterLink.Size = new System.Drawing.Size(73, 13);
            this.TwitterLink.TabIndex = 4;
            this.TwitterLink.Text = "@BobiasMehl";
            this.TwitterLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TwitterLink.Click += new System.EventHandler(this.TwitterLink_Click);
            // 
            // bugReportWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 154);
            this.Controls.Add(this.TwitterLink);
            this.Controls.Add(this.DiscordLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoundAbug);
            this.Name = "bugReportWindows";
            this.Text = "bugReportWindows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FoundAbug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DiscordLink;
        private System.Windows.Forms.Label TwitterLink;
    }
}