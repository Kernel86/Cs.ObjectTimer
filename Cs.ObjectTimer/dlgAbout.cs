/*************************
 * [dlgAbout.cs]
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

namespace Cs.ObjectTimer
{
    public partial class dlgAbout : Form
    {
        public dlgAbout()
        {
            InitializeComponent();

            // Set assignment informations
            lblAssignment.Text = "C# Intermediate - Object Timer";
            lblDate.Text = "2012-10-24";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
