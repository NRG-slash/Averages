using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Averages
{
    public partial class Averages : Form
    {
        public Averages()
        {
            InitializeComponent();
        }

        private void Averages_Load(object sender, EventArgs e)
        {

        }

        private void txtMark1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double firstMark = Convert.ToDouble(txtMark1.Text);
            double secondMark = Convert.ToDouble(txtMark2.Text);
            double thirdMark = Convert.ToDouble(txtMark3.Text);
            double fourthMark = Convert.ToDouble(txtMark4.Text);
            double fifthMark = Convert.ToDouble(txtMark5.Text);
            double average = (firstMark + secondMark + thirdMark + fourthMark + fifthMark) / 5.0;

            lblDisplay.Text = "Your average is " + average;

        }

        private void txtMark2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMark3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMark4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMark5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
