using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCountdown
{
    public partial class TimersPanel : UserControl
    {
        public TimersPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }

    public struct STimerDetails
    {
        public string name;
        public DateTime goalTime;
    }
}
