﻿using WheelOfFortune;
using WheelOfFortune.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class End : Form
    {
        public End(string Winner, string Nickname)
        {
            InitializeComponent();

            lblWinner.Text = Winner;
            if(Winner == Nickname)
            {
                pbWinOrLoss.Image = Resources.WinnerIcon;
            }
            else
            {
                pbWinOrLoss.Image = Resources.LoserIcon;
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Close();
        }

        
    }
}
