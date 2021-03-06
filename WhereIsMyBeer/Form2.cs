﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBeer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (Form1.score < Form1.highScore)
            {
                FinalScore.Text = Form1.score.ToString();
                HoghScore.Text = Form1.highScore.ToString();
                Form1.score = 0;
            }
            else
            {
                FinalScore.Text = "";
                label1.Text = "Congratulations!";
                label1.Left = 320 - (label1.Width / 2) - (FinalScore.Width / 2);
                label2.Text = "Your new High Score is:";
                label2.Left = 320 - (label2.Width / 2) - (HoghScore.Width / 2) - 10;
                HoghScore.Text = Form1.score.ToString();
                HoghScore.Left = label2.Left + label2.Width + 10;
                Form1.score = 0;
            }
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Dispose();
            }
        }
    }
}
