﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasa_Hareket_Takip
{
    public partial class Animation : Form
    {
        public Animation()
        {
            InitializeComponent();
        }
        bool islem = false;
        

        private void Animation_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (islem == false)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if (this.Opacity == 0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    timer2.Enabled = false;
                }
            }
        }
    }
}
