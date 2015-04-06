using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCountdown.View;
using System.Collections;

namespace TheCountdown
{
    public partial class TimersPanel : UserControl
    {
        public TimersPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            timers = new List<TimerDetail>();
            this.Controls.Clear();
            this.Controls.AddRange(timers.ToArray());

            timerNum = 0;

            STimerDetails stam = new STimerDetails();
            stam.goalTime = DateTime.Now.AddMinutes(20);

            STimerDetails stam2 = new STimerDetails();
            stam2.goalTime = DateTime.Now.AddHours(3);

            AddTimer(stam);
            AddTimer(stam2);
            mainTimer.Enabled = true;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            foreach (TimerDetail timer in timers)
            {
                timer.UpdateLabel();
            }
        }

        private void UpdateTimers()
        {
            this.Controls.Clear();
            this.Controls.AddRange(timers.ToArray());
        }

        private void AddTimer(STimerDetails timer)
        {
            TimerDetail details = new TimerDetail(timer);
            details.Location = new Point(0, ((details.Height) * timerNum));
            timers.Add(details);
            timerNum++;
            UpdateTimers();
        }

        List<TimerDetail> timers;
        int timerNum;
    }

    [Serializable()]
    public struct STimerDetails
    {
        public string name;
        public DateTime goalTime;
    }
}
