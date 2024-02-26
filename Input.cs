using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WheelOfFortune
{
    public partial class Input : Form
    {
        public string InputValue { get; private set; }

        public Input(bool vowel)
        {
            InitializeComponent();
            this.ControlBox = false;
            if (vowel)
            {
                txtAnswer.MaxLength = 1;
                txtAnswer.Size = new Size(143, 83);
                txtAnswer.Location = new Point(167, 55);
                txtAnswer.Font = new Font(txtAnswer.Font.FontFamily, 16);
            }
            else
            {
                txtAnswer.Location = new Point(39, 12);
                txtAnswer.Size = new Size(406, 150);
                txtAnswer.Font = new Font(txtAnswer.Font.FontFamily, 14);
                txtAnswer.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            InputValue = txtAnswer.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
