using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Cs.ObjectTimer.StopWatch;

namespace Cs.ObjectTimer
{
    public partial class frmStopWatch : Form
    {
        private CStopWatch _oStopWatch;
        private Timer _oTimer;

        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void frmStopWatch_Load(object sender, EventArgs e)
        {
            if (_oStopWatch == null)
                _oStopWatch = new CStopWatch();

            if (_oTimer == null)
            {
                _oTimer = new Timer();
                _oTimer.Interval = 1;
                _oTimer.Tick += new EventHandler(_oTimer_Tick);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                _oStopWatch.StartClock();
                _oTimer.Start();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                _oStopWatch.StopClock();
                _oTimer.Stop();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _oStopWatch.Elapsed;
        }
    }
}
