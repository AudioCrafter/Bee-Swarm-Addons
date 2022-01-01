using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace Beeswarm_timer_v3
{
    public partial class BeeswarmAddonsV1 : Form

    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public BeeswarmAddonsV1()
        {
            InitializeComponent();
        }

        int hour, minute, second;

        int snowBearTimeLeft;
        int stockingsTimeLeft;
        int snowCanonTimeLeft;
        int namnamTimeLeft;
        int candlesTimeLeft;
        int wrathTimeLeft;
        int kickTimeLeft;
        int WealthClockTimeLeft;

        int SpaceTimeTimer;

        string snowBearAlert = "https://otto.mauz.name/nextcloud/s/Dg4s5fGA9BTqjoT/download/Snol_Bier.mp3";
        string stockingsAlert = "https://otto.mauz.name/nextcloud/s/kyncqRBxNnwpjM2/download/Glocken_in_den_socken.mp3";
        string snowCanonAlert = "https://otto.mauz.name/nextcloud/s/55BBc2pjea6sBgf/download/Snol_Maschine.mp3";
        string namnamnamAlert = "https://otto.mauz.name/nextcloud/s/o93N6PCy3G6twHS/download/NamNamNam.mp3";
        string candleAlert = "https://otto.mauz.name/nextcloud/s/jMsJMFWmGQ56i7M/download/candle.mp3";
        string festiveWrathAlert = "https://otto.mauz.name/nextcloud/s/ZAQjsrQHn6eezRP/download/Festive_Wrath.mp3";
        string puffshroomAlert = "https://otto.mauz.name/nextcloud/s/cKqwidGSz68R6jF/download";
        string mondoAlert = "https://otto.mauz.name/nextcloud/s/r2octHQd49pJM3f/download/Mondo_Chick.mp3";
        string kickAlert = "https://otto.mauz.name/nextcloud/s/5xG58C7Xci7R534/download/kick%20sound.mp3";
        string wealthAlert = "https://otto.mauz.name/nextcloud/s/gSAKMFPeE8HtcwT/download/Werte_Uhr.mp3";


        int snowbearTime = 5400;
        int stockingsTime = 3600;
        int snowCanonTime = 7200;
        int namnamTime = 5400;
        int candleTime = 14400;
        int festiveWrathTime = 1800;
        int kickTime = 1080;
        int WealthTime = 3600;


        int snowbearYellowTime = 300;
        int snowbearRedTime = 120;

        int stockingsYellowTime = 300;
        int stockingsRedTime = 120;

        int snowcanonYellowTime = 300;
        int snowcanonRedTime = 120;

        int namnamnamYellowTime = 300;
        int namnamnamRedTime = 120;

        int candleYellowTime = 300;
        int candleRedTime = 120;

        int wrathYellowTime = 300;
        int wrathRedTime = 120;

        int wealthYellowTime = 300;
        int wealthhRedTime = 120;

        int kickYellowTime = 300;
        int kickRedTime = 120;

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (snowBearTimeLeft > 0)
            {
                snowBearTimeLeft = snowBearTimeLeft - 1;
                TimeSpan snowBearTimeSpan = TimeSpan.FromSeconds(snowBearTimeLeft);
                snowBearTimeDisplay.Text = snowBearTimeSpan.ToString();
            }
            else
            {
                snowBearTimer.Stop();
                axWindowsMediaPlayer1.URL = snowBearAlert;
                snowBearTimeLeft = snowbearTime;
                snowBearTimeDisplay.Text = "Ready!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            snowBearTimeLeft = snowbearTime;
            stockingsTimeLeft = stockingsTime;
            snowCanonTimeLeft = snowCanonTime;
            namnamTimeLeft = namnamTime;
            candlesTimeLeft = candleTime;
            wrathTimeLeft = festiveWrathTime;
            kickTimeLeft = kickTime;
            WealthClockTimeLeft = WealthTime;
            loop.Start();
            


        }

        private void snowBearTimerStart_Click(object sender, EventArgs e)
        {
            snowBearTimer.Start();
            snowBearTimeLeft = snowbearTime;
            snowBearTimeDisplay.Text = "Started!";
;

        }

        private void snowBearTimeDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void StokingsTimerStart_Click(object sender, EventArgs e)
        {
            stockingsTimer.Start();
            stockingsTimeLeft = stockingsTime;
            SstockingsTimeDisplay.Text = "Started!";
        }

        private void SstockingsTimeDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockingsTimer_Tick(object sender, EventArgs e)
        {
            if(stockingsTimeLeft > 0)
            {
                stockingsTimeLeft = stockingsTimeLeft - 1;
                TimeSpan stockingsTimeSpan = TimeSpan.FromSeconds(stockingsTimeLeft);
                SstockingsTimeDisplay.Text = stockingsTimeSpan.ToString();
            }
            else
            {
                stockingsTimer.Stop();
                axWindowsMediaPlayer1.URL = stockingsAlert;
                stockingsTimeLeft = stockingsTime;
                SstockingsTimeDisplay.Text = "Ready!";
            }
                  
        }

        private void snowCanonTimer_Tick(object sender, EventArgs e)
        {
            if(snowCanonTimeLeft > 0)
            {
                snowCanonTimeLeft = snowCanonTimeLeft - 1;
                TimeSpan snowCanonTimeSpan = TimeSpan.FromSeconds(snowCanonTimeLeft);
                snowCanonTimeDIsplay.Text = snowCanonTimeSpan.ToString();
            }
            else
            {
                snowCanonTimer.Stop();
                axWindowsMediaPlayer1.URL=snowCanonAlert;
                snowCanonTimeLeft=snowCanonTime;
                snowCanonTimeDIsplay.Text = "Ready!";
            }
                  
        }

        private void snowCanonStart_Click(object sender, EventArgs e)
        {
            snowCanonTimer.Start();
            snowCanonTimeLeft = snowCanonTime;
            snowCanonTimeDIsplay.Text = "Started!";
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 settingsWindow = new Form2();
            settingsWindow.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            namNamTimer.Start();
            namnamTimeLeft = namnamTime;
            namNamTimeDisplay.Text = "Started!";
        }

        private void namNamTimer_Tick(object sender, EventArgs e)
        {
            if(namnamTimeLeft > 0)
            {
                namnamTimeLeft = namnamTimeLeft - 1;   
                TimeSpan namnamTimeSpan = TimeSpan.FromSeconds(namnamTimeLeft);
                namNamTimeDisplay.Text = namnamTimeSpan.ToString();
            }
            else
            {
                namNamTimer.Stop();
                axWindowsMediaPlayer1.URL = namnamnamAlert;
                namnamTimeLeft = namnamTime;
                namNamTimeDisplay.Text = "Ready!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            wrathTimer.Start();
            wrathTimeLeft = festiveWrathTime;
            wrathTimeDisplay.Text = "Started!";
        }

        private void wrathTimeDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void wrathTimer_Tick(object sender, EventArgs e)
        {
            if (wrathTimeLeft > 0)
            {
                wrathTimeLeft = wrathTimeLeft - 1;
                TimeSpan wrathTimeSpan = TimeSpan.FromSeconds(wrathTimeLeft);
                wrathTimeDisplay.Text = wrathTimeSpan.ToString();
            }
            else
            {
                wrathTimer.Stop();
                axWindowsMediaPlayer1.URL = festiveWrathAlert;
                wrathTimeLeft = festiveWrathTime;
                wrathTimeDisplay.Text = "Ready!";
            }
        }

        private void candledTimer_Tick(object sender, EventArgs e)
        {
            if(candlesTimeLeft > 0)
            {

                candlesTimeLeft = candlesTimeLeft - 1; 
                TimeSpan candlesTimeSpan = TimeSpan.FromSeconds(candlesTimeLeft);
                candlesTimeDisplay.Text=candlesTimeSpan.ToString();
            }
            else
            {

                candledTimer.Stop();
                axWindowsMediaPlayer1.URL = candleAlert;
                candlesTimeLeft = candleTime;
                candlesTimeDisplay.Text = "Ready!";
            }
        }

        private void candlesStart_Click(object sender, EventArgs e)
        {
            candledTimer.Start();
            candlesTimeLeft = candleTime;
            candlesTimeDisplay.Text = "Started!";

        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost= false;
            }
                   
        }

        private void settingswindow1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void mondoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopAllTimersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockingsTimer.Stop();
            snowBearTimer.Stop();
            snowCanonTimer.Stop();
            namNamTimer.Stop();
            candledTimer.Stop();
            wrathTimer.Stop();
            kickTimer.Stop();
            SstockingsTimeDisplay.Text = "Stopped!";
            snowBearTimeDisplay.Text = "Stopped!";
            snowCanonTimeDIsplay.Text = "Stopped!";
            namNamTimeDisplay.Text = "Stopped!";
            candlesTimeDisplay.Text = "Stopped!";
            wrathTimeDisplay.Text = "Stopped!";
            kickTimeDisplay.Text = "Stopped!";
        }

        private void nachtModusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nachtModusToolStripMenuItem.Checked)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
                NightModeEnabledSign.Visible = true;

            }
            else
            {
                axWindowsMediaPlayer1.settings.volume = 100;
                NightModeEnabledSign.Visible = false;  
            }
             

        }

        private void label1_Click(object sender, EventArgs e)
        {
            nachtModusToolStripMenuItem.Checked = false;
            axWindowsMediaPlayer1.settings.volume = 100;
            NightModeEnabledSign.Visible = false;
        }

        private void kickTimer_Tick(object sender, EventArgs e)
        {

            if(kickTimeLeft > 0)
            {
                kickTimeLeft = kickTimeLeft - 1;
                TimeSpan kickTimeSpan = TimeSpan.FromSeconds(kickTimeLeft);
                kickTimeDisplay.Text = kickTimeSpan.ToString();
            }
            else
            {
                kickTimeDisplay.Text = "Move!";
                kickTimer.Stop();
                axWindowsMediaPlayer1.URL = kickAlert;
                

            }
        }

        private void kickTimerStart_Click(object sender, EventArgs e)
        {
            kickTimer.Start();
            kickTimeDisplay.Text = "Started!";
            kickTimeLeft = kickTime;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ActiveForm.Opacity = ((double)(trackBar1.Value) / 10.0);
        }

        private void showOpacitySliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showOpacitySliderToolStripMenuItem.Checked)
            {
                trackBar1.Visible = true;
                OpacityLabel.Visible = true;
            }
            else
            {
                trackBar1.Visible = false;
                OpacityLabel.Visible=false;
            }
        }

        private void antiAFKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AntiAfkCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void antiAFKTimer_Tick(object sender, EventArgs e)
        {

        }

        private void WealthClokStart_Click(object sender, EventArgs e)
        {
            WealthTimer.Start();
            WealthClockTimeDisplay.Text = "Started!";
        }

        private void WealthTimer_Tick(object sender, EventArgs e)
        {
            if(WealthClockTimeLeft > 0)
            {
                WealthClockTimeLeft = WealthClockTimeLeft - 1;
                TimeSpan WealthTimeSpan = TimeSpan.FromSeconds(WealthClockTimeLeft);
                WealthClockTimeDisplay.Text = WealthTimeSpan.ToString();
            }
            else
            {
                WealthTimer.Stop();
                axWindowsMediaPlayer1.URL = wealthAlert;
                WealthClockTimeDisplay.Text = "Ready!";
                WealthClockTimeLeft = WealthTime;

            }


        }

        private void stockingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stockingsToolStripMenuItem.Checked)
            {
                SstockingsTimeDisplay.Visible = true;
                StokingsTimerStart.Visible = true;
            }
            else
            {
                SstockingsTimeDisplay.Visible = false;
                StokingsTimerStart.Visible = false;
            }
        }

        private void snowbearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snowbearToolStripMenuItem.Checked)
            {
                snowBearTimeDisplay.Visible = true;
                snowBearTimerStart.Visible = true;
            }
            else
            {
                snowBearTimeDisplay.Visible = false;
                snowBearTimerStart.Visible = false;
            }
        }

        private void snowcanonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snowcanonToolStripMenuItem.Checked)
            {
                snowCanonTimeDIsplay.Visible = true;
                snowCanonStart.Visible = true;
            }
            else
            {
                snowCanonTimeDIsplay.Visible = false;
                snowCanonStart.Visible = false;
            }
        }

        private void namNamNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (namNamNamToolStripMenuItem.Checked)
            {
                namNamTimeDisplay.Visible = true;
                namNamNamStart.Visible = true;
            }
            else
            {
                namNamTimeDisplay.Visible = false;
                namNamNamStart.Visible = false;
            }
        }

        private void candlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (candlesToolStripMenuItem.Checked)
            {
                candlesStart.Visible = true;
                candlesTimeDisplay.Visible=true;
            }
            else
            {
                candlesStart.Visible = false;
                candlesTimeDisplay.Visible = false;
            }
        }

        private void wrathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wrathToolStripMenuItem.Checked)
            {
                wrathTimeDisplay.Visible = true;
                button1.Visible = true;
            }
            else
            {
                wrathTimeDisplay.Visible = false;
                button1.Visible = false;
            }
        }

        private void wealthClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wealthClockToolStripMenuItem.Checked)
            {
                WealthClockTimeDisplay.Visible = true;
                WealthClokStart.Visible = true;
            }
            else
            {
                WealthClockTimeDisplay.Visible = false;
                WealthClokStart.Visible = false;
            }
        }

        private void kickTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kickTimerToolStripMenuItem.Checked)
            {
                kickTimeDisplay.Visible = true ;
                kickTimerStart.Visible = true ;
            }
            else
            {
                kickTimeDisplay.Visible = false;
                kickTimerStart.Visible = false;
            }
        }

        private void overlayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (overlayModeToolStripMenuItem.Checked)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                TopBar.Visible = true;

            }
            else
            {
                TopBar.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PuffMondoTimer_Tick(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            Ring_Alarm();
        }

        private void savePreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showVolumeSliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showVolumeSliderToolStripMenuItem.Checked)
            {
                VolumeSlider.Visible = true;
                VolumeLabel.Visible = true;

            }
            else
            {
                VolumeSlider.Visible = false;
                VolumeLabel.Visible= false;
            }
        }

        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = VolumeSlider.Value;
        }

        private void stockingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = stockingsAlert;
        }

        private void snowbearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = snowBearAlert;
        }

        private void snowCanonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = snowCanonAlert;
        }

        private void namNamNamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = namnamnamAlert;
        }

        private void candlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = candleAlert;
        }

        private void wrathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = festiveWrathAlert;
        }

        private void wealthClockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = wealthAlert;
        }

        private void kickTimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = kickAlert;
        }

        private void TopBarLabel_Click(object sender, EventArgs e)
        {
          
        }

        private void TopBarLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BeeswarmAddonsV1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void WealthClockTimeDisplay_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void loop_Tick(object sender, EventArgs e)
        {
            if (candlesTimeLeft > 0 && candledTimer.Enabled)
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.Cyan;


            }
            else
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }




            //SnowBear Coloring
            if(snowBearTimeLeft > snowbearYellowTime && snowBearTimer.Enabled )
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (snowBearTimeLeft <= snowbearYellowTime && snowBearTimeLeft > snowbearRedTime && snowBearTimer.Enabled)
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (snowBearTimeLeft <= snowbearRedTime && snowBearTimeLeft >= 0 && snowBearTimer.Enabled)
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if(snowBearTimeDisplay.Text == "Started!")
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (snowBearTimeDisplay.Text == "Ready!")
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                snowBearTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //Stocking Coloring
            if (stockingsTimeLeft > stockingsYellowTime && stockingsTimer.Enabled)
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (stockingsTimeLeft <= stockingsYellowTime && stockingsTimeLeft > stockingsRedTime && stockingsTimer.Enabled)
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (stockingsTimeLeft <= stockingsRedTime && stockingsTimeLeft >= 0 && stockingsTimer.Enabled)
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (SstockingsTimeDisplay.Text == "Started!")
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (SstockingsTimeDisplay.Text == "Ready!")
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                SstockingsTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //Snow Canon Coloring
            if (snowCanonTimeLeft > snowcanonYellowTime && snowCanonTimer.Enabled)
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (snowCanonTimeLeft <= snowcanonYellowTime && snowCanonTimeLeft > snowcanonRedTime && snowCanonTimer.Enabled)
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (snowCanonTimeLeft <= snowcanonRedTime && snowCanonTimeLeft >= 0 && snowCanonTimer.Enabled)
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (SstockingsTimeDisplay.Text == "Started!")
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (SstockingsTimeDisplay.Text == "Ready!")
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                snowCanonTimeDIsplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //NamNamNam Coloring
            if (namnamTimeLeft > namnamnamYellowTime && namNamTimer.Enabled)
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (namnamTimeLeft <= namnamnamYellowTime && namnamTimeLeft > namnamnamRedTime && namNamTimer.Enabled)
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (namnamTimeLeft <= namnamnamRedTime && namnamTimeLeft >= 0 && namNamTimer.Enabled)
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (namNamTimeDisplay.Text == "Started!")
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (namNamTimeDisplay.Text == "Ready!")
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                namNamTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //Candle Coloring
            if (candlesTimeLeft > candleYellowTime && candledTimer.Enabled)
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (candlesTimeLeft <= candleYellowTime && candlesTimeLeft > candleRedTime && candledTimer.Enabled)
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (candlesTimeLeft <= candleYellowTime && candlesTimeLeft >= 0 && candledTimer.Enabled)
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (candlesTimeDisplay.Text == "Started!")
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (candlesTimeDisplay.Text == "Ready!")
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                candlesTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //Wrath Coloring
            if (wrathTimeLeft > wrathYellowTime && wrathTimer.Enabled)
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (wrathTimeLeft <= wrathYellowTime && wrathTimeLeft > wrathRedTime && wrathTimer.Enabled)
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (wrathTimeLeft <= wrathYellowTime && wrathTimeLeft >= 0 && wrathTimer.Enabled)
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (wrathTimeDisplay.Text == "Started!")
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (wrathTimeDisplay.Text == "Ready!")
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                wrathTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //Wealth Coloring
            if (WealthClockTimeLeft > wealthYellowTime && WealthTimer.Enabled)
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (WealthClockTimeLeft <= wealthYellowTime && WealthClockTimeLeft > wealthhRedTime && WealthTimer.Enabled)
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (WealthClockTimeLeft <= wealthYellowTime && WealthClockTimeLeft >= 0 && WealthTimer.Enabled)
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (WealthClockTimeDisplay.Text == "Started!")
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (WealthClockTimeDisplay.Text == "Ready!")
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                WealthClockTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }



            //kick timer Coloring
            if (kickTimeLeft > kickYellowTime && kickTimer.Enabled)
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.Cyan;
            }
            else if (kickTimeLeft <= kickYellowTime && kickTimeLeft > kickRedTime && kickTimer.Enabled)
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (kickTimeLeft <= kickYellowTime && kickTimeLeft >= 0 && kickTimer.Enabled)
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.Red;
            }
            else if (kickTimeDisplay.Text == "Started!")
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else if (kickTimeDisplay.Text == "Move!")
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                kickTimeDisplay.ForeColor = System.Drawing.Color.DarkCyan;
            }

        }

        void Ring_Alarm()
        {
            //Mondo
            if (minute == 56 && second == 59 && mondoToolStripMenuItem.Checked && nachtModusToolStripMenuItem.Checked == false)
            {
                axWindowsMediaPlayer1.URL = mondoAlert;
            };

            //Puffshroom XX:15 Uhr
            if (minute == 14 && second == 59 && puffshroomsXX15UhrToolStripMenuItem.Checked && nachtModusToolStripMenuItem.Checked == false)
            {
                axWindowsMediaPlayer1.URL = puffshroomAlert;
            };

            //Puffshroom XX:45 Uhr
            if (minute == 44 && second == 59 && puffshroomsXX45UhrToolStripMenuItem.Checked && nachtModusToolStripMenuItem.Checked == false)
            {
                axWindowsMediaPlayer1.URL = puffshroomAlert;
            };
        }

        public void GetSettings()
        {
            
        }
    }
}
