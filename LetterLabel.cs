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
    public partial class LetterLabel : UserControl
    {
        public LetterLabel()
        {
            InitializeComponent();
        }
        public override string Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public override Color BackColor
        {
            get { return label1.BackColor; }
            set { label1.BackColor = value; }
        }
        public BorderStyle _BorderStyle
        {
            get { return label1.BorderStyle; }
            set { label1.BorderStyle = value; }
        }
    }
}
