﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10202_CS_Project
{
    public partial class Week09 : Form
    {
        public Week09()
        {
            InitializeComponent();
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                toggleButton.Text = "暫停";
            }
            else
            {
                timer1.Enabled = false;
                toggleButton.Text = "繼續";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (northOption.Checked == true)
                carLabel.Top -= 1;
            else if (westOption.Checked == true)
                carLabel.Left -= 1;
            else if (eastOption.Checked == true)
                carLabel.Left += 1;
            else if (southOption.Checked == true)
                carLabel.Top += 1;
        }

        private void slowOption_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
        }

        private void mediumOption_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void fastOption_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Visible = false;
            home.Visible = true;
        }

        private void Week09_Load(object sender, EventArgs e)
        {

        }
    }
}
