using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beeswarm_timer_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int snowBearTimeLeft;
        int stockingsTimeLeft;
        int snowCanonTimeLeft;
        string snowBearAlert = "https://otto.mauz.name/nextcloud/s/rRHALSPaci7zKHz/download/snow%20bear%20alert.mp3";
        string stockingsAlert = "https://otto.mauz.name/nextcloud/s/YbzASG9E28GSspt/download/stokings%20alert.mp3";
        string snowCanonAlert = "";

        int snowbearTime = 5400;
        int stockingsTime = 3600;
        int snowCanonTime = 7200;

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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snowBearTimeLeft = snowbearTime;
            stockingsTimeLeft = stockingsTime;
            snowCanonTimeLeft = snowCanonTime;
        }

        private void snowBearTimerStart_Click(object sender, EventArgs e)
        {
            snowBearTimer.Start();

        }

        private void snowBearTimeDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void StokingsTimerStart_Click(object sender, EventArgs e)
        {
            stockingsTimer.Start();
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
            }
                  
        }
    }
}
