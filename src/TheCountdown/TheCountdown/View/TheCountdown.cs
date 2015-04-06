using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCountdown
{
    public partial class TheCountdown : Form
    {
        public TheCountdown()
        {
            InitializeComponent();
            this.pnlLogo.BackColor = Color.FromArgb(66, 112, 208);
            viewTimers = new TimersPanel();
            addTimer = new AddTimerPanel();
        }

        private void addTimerBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(addTimer);
        }

        private void btnTimers_Click(object sender, EventArgs e)
        {
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(viewTimers);
        }

        private void pctBox_MouseHover(object sender, EventArgs e)
        {
            pctBox.BackgroundImage = global::TheCountdown.Properties.Resources.TimersHover;
        }

        private void pctBox_MouseLeave(object sender, EventArgs e)
        {
            pctBox.BackgroundImage = global::TheCountdown.Properties.Resources.Timers;
        }

        private void pctAddTimer_MouseHover(object sender, EventArgs e)
        {
            pctAddTimer.BackgroundImage = global::TheCountdown.Properties.Resources.AddTimerHover;
        }

        private void pctAddTimer_MouseLeave(object sender, EventArgs e)
        {
            pctAddTimer.BackgroundImage = global::TheCountdown.Properties.Resources.AddTimer;
        }

        private void pctPastTimers_MouseHover(object sender, EventArgs e)
        {
            pctPastTimers.BackgroundImage = global::TheCountdown.Properties.Resources.PastTimersHover;
        }

        private void pctPastTimers_MouseLeave(object sender, EventArgs e)
        {
            pctPastTimers.BackgroundImage = global::TheCountdown.Properties.Resources.PastTimers;
        }

        private TimersPanel viewTimers;
        private AddTimerPanel addTimer;
    }
}
