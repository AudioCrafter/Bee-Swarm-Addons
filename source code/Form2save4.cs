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
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public TextBox StockingsInput;

        int stokingsTimeInputStr = 1;
        public Form2()
        {
            InitializeComponent();
            Instance = this; 
            StockingsInput = stockingsTimeInput;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            settingsStockingstimeInput.Text = Properties.Settings.Default.Stockingstime.ToString();
            settingsSnowBearTimeInput.Text = Properties.Settings.Default.SnowbearTime.ToString();
            settingsSnowcanonTimeInput.Text = Properties.Settings.Default.SnowcanonTime.ToString();
            settingsFeastTimeinput.Text = Properties.Settings.Default.BeesmasFeastTime.ToString();
            SettingscandlesTimeInput.Text = Properties.Settings.Default.CandlesTime.ToString();
            settingsWreathTimeInput.Text = Properties.Settings.Default.WreathTime.ToString();
            settingsWealthTimeInput.Text = Properties.Settings.Default.WealthTime.ToString();
            SettingsKickTimerTimeInput.Text = Properties.Settings.Default.KickTime.ToString();
            SettingstenbeesMMTimeInput.Text = Properties.Settings.Default.tenbeesMMtime.ToString();
            SettingsfiveteenbeesMMTimeInput.Text = Properties.Settings.Default.fiveteenbeesMMtime.ToString();
            SettingthirtyfiveBeesMMTimeInput.Text = Properties.Settings.Default.thirtyfivebeesMMtime.ToString();
            SettingsNightMMTimeInput.Text = Properties.Settings.Default.NightMMtime.ToString();
            SettingsMondoTimeInput.Text = Properties.Settings.Default.MondoTimeMinute.ToString();
            settingsPuffshroom15Input.Text = Properties.Settings.Default.Puffshroom15minute.ToString();
            settingsPuffshroom45Input.Text = Properties.Settings.Default.Puffshroom45minute.ToString();

            StockingsUrlInput.Text = Properties.Settings.Default.StockingsAlertURL.ToString();
            snowbearUrlInput.Text = Properties.Settings.Default.SnowbearAlertURL.ToString();
            snowcanonUrlInput.Text = Properties.Settings.Default.SnowcanonAlertURL.ToString();
            beesmasfeastUrlInput.Text = Properties.Settings.Default.FeastAlertURL.ToString();
            candlesUrlInput.Text = Properties.Settings.Default.CandlesAlertURL.ToString();
            wreathUrlInput.Text = Properties.Settings.Default.WreathAlertURL.ToString();
            wealthUrlInput.Text = Properties.Settings.Default.WealthAlertURL.ToString();
            kickUrlInput.Text = Properties.Settings.Default.KickAlertURL.ToString();
            mondoUrlInput.Text = Properties.Settings.Default.MondoAlertURL.ToString();
            PuffshroomTimerUrlInput.Text = Properties.Settings.Default.PuffshroomsAlertURL.ToString();
            tenBeeMMInput.Text = Properties.Settings.Default.tenbeesMMalertURL.ToString();
            fiveteenBeeMMInput.Text = Properties.Settings.Default.fiveteenbeesMMalertURL.ToString();
            thirtyfiveBeeMMInput.Text = Properties.Settings.Default.thirtyfivebeesMMalertURL.ToString();
            NightMMUrlInput.Text = Properties.Settings.Default.NightMMalertURL.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stockingstime = Convert.ToInt32(settingsStockingstimeInput.Text);
            Properties.Settings.Default.SnowbearTime = Convert.ToInt32(settingsSnowBearTimeInput.Text);
            Properties.Settings.Default.SnowcanonTime = Convert.ToInt32(settingsSnowcanonTimeInput.Text);
            Properties.Settings.Default.BeesmasFeastTime = Convert.ToInt32(settingsFeastTimeinput.Text);
            Properties.Settings.Default.CandlesTime = Convert.ToInt32(SettingscandlesTimeInput.Text);
            Properties.Settings.Default.WreathTime = Convert.ToInt32(settingsWreathTimeInput.Text);
            Properties.Settings.Default.WealthTime = Convert.ToInt32(settingsWealthTimeInput.Text);
            Properties.Settings.Default.tenbeesMMtime = Convert.ToInt32(SettingstenbeesMMTimeInput.Text);
            Properties.Settings.Default.fiveteenbeesMMtime = Convert.ToInt32(SettingsfiveteenbeesMMTimeInput.Text);
            Properties.Settings.Default.thirtyfivebeesMMtime = Convert.ToInt32(SettingthirtyfiveBeesMMTimeInput.Text);
            Properties.Settings.Default.NightMMtime = Convert.ToInt32(SettingsNightMMTimeInput.Text);
            Properties.Settings.Default.KickTime = Convert.ToInt32(SettingsKickTimerTimeInput.Text);
            Properties.Settings.Default.MondoTimeMinute = Convert.ToInt32(SettingsMondoTimeInput.Text);
            Properties.Settings.Default.Puffshroom15minute = Convert.ToInt32(settingsPuffshroom15Input.Text);
            Properties.Settings.Default.Puffshroom45minute = Convert.ToInt32(settingsPuffshroom45Input.Text);

           // Properties.Settings.Default.StockingsAlertURL = StockingsUrlInput.Text;
           // Properties.Settings.Default.SnowbearAlertURL = snowbearUrlInput.Text;
           // Properties.Settings.Default.SnowcanonAlertURL = snowcanonUrlInput.Text;
           // Properties.Settings.Default.FeastAlertURL = beesmasfeastUrlInput.Text;
           // Properties.Settings.Default.CandlesAlertURL = candlesUrlInput.Text;
           // Properties.Settings.Default.WreathAlertURL = wreathUrlInput.Text;
           // Properties.Settings.Default.WealthAlertURL = wealthUrlInput.Text;
           // Properties.Settings.Default.KickAlertURL = kickUrlInput.Text;



            Properties.Settings.Default.Save();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void settingsSoundsTab_Click(object sender, EventArgs e)
        {

        }

        private void SaveButtonSoundpage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stockingstime = Convert.ToInt32(settingsStockingstimeInput.Text);
            Properties.Settings.Default.SnowbearTime = Convert.ToInt32(settingsSnowBearTimeInput.Text);
            Properties.Settings.Default.SnowcanonTime = Convert.ToInt32(settingsSnowcanonTimeInput.Text);
            Properties.Settings.Default.BeesmasFeastTime = Convert.ToInt32(settingsFeastTimeinput.Text);
            Properties.Settings.Default.CandlesTime = Convert.ToInt32(SettingscandlesTimeInput.Text);
            Properties.Settings.Default.WreathTime = Convert.ToInt32(settingsWreathTimeInput.Text);
            Properties.Settings.Default.WealthTime = Convert.ToInt32(settingsWealthTimeInput.Text);
            Properties.Settings.Default.KickTime = Convert.ToInt32(SettingsKickTimerTimeInput.Text);
            Properties.Settings.Default.MondoTimeMinute = Convert.ToInt32(SettingsMondoTimeInput.Text);
            Properties.Settings.Default.Puffshroom15minute = Convert.ToInt32(settingsPuffshroom15Input.Text);
            Properties.Settings.Default.Puffshroom45minute = Convert.ToInt32(settingsPuffshroom45Input.Text);

            Properties.Settings.Default.StockingsAlertURL = StockingsUrlInput.Text;
            Properties.Settings.Default.SnowbearAlertURL = snowbearUrlInput.Text;
            Properties.Settings.Default.SnowcanonAlertURL = snowcanonUrlInput.Text;
            Properties.Settings.Default.FeastAlertURL = beesmasfeastUrlInput.Text;
            Properties.Settings.Default.CandlesAlertURL = candlesUrlInput.Text;
            Properties.Settings.Default.WreathAlertURL = wreathUrlInput.Text;
            Properties.Settings.Default.WealthAlertURL = wealthUrlInput.Text;
            Properties.Settings.Default.KickAlertURL = kickUrlInput.Text;
            Properties.Settings.Default.MondoAlertURL = mondoUrlInput.Text;
            Properties.Settings.Default.PuffshroomsAlertURL = PuffshroomTimerUrlInput.Text;
            Properties.Settings.Default.tenbeesMMalertURL = tenBeeMMInput.Text;
            Properties.Settings.Default.fiveteenbeesMMalertURL = fiveteenBeeMMInput.Text;
            Properties.Settings.Default.thirtyfivebeesMMalertURL = thirtyfiveBeeMMInput.Text;
            Properties.Settings.Default.NightMMalertURL = NightMMUrlInput.Text;



            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
