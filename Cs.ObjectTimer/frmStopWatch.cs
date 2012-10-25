/*************************
 * [frmStopWatch.cs]
 * C# Intermediate
 * Shawn Novak
 * 2012-10-24
 *************************/

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
            // Create new CStopWatch and Timer objects
            if (_oStopWatch == null)
                _oStopWatch = new CStopWatch();

            if (_oTimer == null)
            {
                _oTimer = new Timer();
                _oTimer.Interval = 1;
                _oTimer.Tick += new EventHandler(_oTimer_Tick);
            }
        }

        private void frmStopWatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cleanup at close
            if (_oStopWatch != null)
                _oStopWatch = null;
            if (_oTimer != null)
            {
                _oTimer.Dispose();
                _oTimer = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset Form
                ResetForm();

                // Start the StopWatch
                _oStopWatch.StartClock();

                // Start the Timer
                _oTimer.Start();

                // Set status
                lblStatus.Text = "Running...";

                // Disable Clear
                mnuClear.Enabled = false;
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
                // Stop the StopWatch
                _oStopWatch.StopClock();

                // Stop the Timer
                _oTimer.Stop();

                // Set status
                lblStatus.Text = "Waiting...";

                // Set elapsed time
                lblElapsedTotal.Text = _oStopWatch.Elapsed;

                // Enable Clear
                mnuClear.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void _oTimer_Tick(object sender, EventArgs e)
        {
            // Make the timer tick
            lblTimer.Text = _oStopWatch.Elapsed;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            // Quit
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            // Show Abut dialog
            dlgAbout frmAbout = new dlgAbout();
            frmAbout.ShowDialog();
            frmAbout.Dispose();
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            // Reset the form
            ResetForm();
        }

        // Rest the Form
        private void ResetForm()
        {
            lblTimer.Text = "00:00:00";
            lblStatus.Text = "Waiting...";
            lblElapsedTotal.Text = string.Empty;
        }
    }
}
