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
    public partial class AddTimerPanel : UserControl
    {
        public AddTimerPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void calander_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = e.End.ToShortDateString();
        }

        private void btnAddTimer_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Task name could not be empty");
                return;
            }

            bool dateTimeValid = true;

            if (calander.SelectionEnd.Date < DateTime.Now.Date)
            {
                dateTimeValid = false;
            }
            else
            {
                if ((calander.SelectionEnd.Date == DateTime.Now.Date) &&
                    dateTimePicker1.Value.TimeOfDay <= DateTime.Now.TimeOfDay)
                {
                    dateTimeValid = false;
                }
            }

            if (!dateTimeValid)
            {
                MessageBox.Show("Timer can be set to a future time");
                return;
            }

            STimerDetails s = getDetails(txtName.Text, 
                                         calander.SelectionEnd.Date, 
                                         dateTimePicker1.Value.TimeOfDay);

            if (saveTimerDetails(s))
            {
                MessageBox.Show("Can't set timer.");
            }
        }

        public STimerDetails getDetails(string name, DateTime date, TimeSpan time)
        {
            STimerDetails newTimer;

            newTimer.name = name;
            newTimer.goalTime = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds, 0);

            return newTimer;
        }

        public bool saveTimerDetails(STimerDetails details)
        {
            return true;
        }
    }
}
