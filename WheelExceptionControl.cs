using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class WheelExceptionControl : UserControl
    {
        public WheelExceptionControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return lblWheelEx.Text; }
            set { lblWheelEx.Text = value; }
        }

    }
}
