using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCountdown.View
{
    public partial class TimerDetail : UserControl
    {
        public TimerDetail(STimerDetails timerDetails)
        {
            InitializeComponent();
            this.endTime = timerDetails.goalTime;
        }

        public void UpdateLabel()
        {
            TimeSpan gap = endTime.Subtract(DateTime.Now);

            if (gap.TotalSeconds <= 0)
            {
                lblTime.Text = "00:00:00";
                lblStatus.Text = "Passed";
            }
            else
            {
                lblTime.Text = gap.Hours + ":" + gap.Minutes + ":" + gap.Seconds;
                lblStatus.Text = "Active";
            }
        }

        DateTime endTime;
    }
}
