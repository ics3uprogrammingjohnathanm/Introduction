using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldInt
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello, World!";
        }

        private void radBengali_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "ওহে বিশ্ব!";

        }

        private void radChinese_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "你好，世界！";

        }

        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hallo Welt!";

        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {
           

        }
    }
}
