﻿using System;
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
 * Daily Assignment – Day #6 - Hello World with Menu
 * This Program has a menu with a menu item which closes the program
*/
namespace HelloWorldMenuJohnathanM
{
    public partial class frmHelloWorldMenu : Form
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
