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
    public partial class Form3 : Form
    {

        public static Form3 Instance;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://15.ai/");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ActiveCaption;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ActiveBorder;
        }
    }
}
