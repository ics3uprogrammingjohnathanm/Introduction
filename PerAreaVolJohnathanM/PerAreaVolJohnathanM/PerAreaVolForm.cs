using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Johnathan Meloche
 * Created on: 02/22/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Perimeter, Area, Volume
 * This program calculates the equation in the button and changes the label's text to the answer
*/
namespace PerAreaVolJohnathanM
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void btnEquation1_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(2 + Math.Pow(3, 4));
        }

        private void btnEquation2_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(5 - 2 * 3);
        }

        private void btnEquation3_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(Math.Pow(4, 2) + 7);
        }

        private void btnEquation4_Click(object sender, EventArgs e)
        {
            lblAnswer4.Text = Convert.ToString(10 - 3 + 4);
        }
    }
}
