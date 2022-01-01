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
    public partial class bugReportWindows : Form
    {
        public bugReportWindows()
        {
            InitializeComponent();
        }

        private void DiscordLink_Click(object sender, EventArgs e)
        {

        }

        private void DiscordLink_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TwitterLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/bobiasmehl");

        }

        private void FoundAbug_Click(object sender, EventArgs e)
        {

        }
    }
}
