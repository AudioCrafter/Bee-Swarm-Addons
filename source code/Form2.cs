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
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stockingstime = Convert.ToInt32(settingsStockingstimeInput.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
