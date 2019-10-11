using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan datetimeLeft = (monthCalendar1.SelectionStart - DateTime.Now);

            lblDaysText.Text = datetimeLeft.Days.ToString();
            lblHoursText.Text = datetimeLeft.Hours.ToString();
            lblMinutesText.Text = datetimeLeft.Minutes.ToString();
            lblSecondsText.Text = datetimeLeft.Seconds.ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
