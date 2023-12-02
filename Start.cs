using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoloFortunyPL
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            Game GameForm = new Game();
            GameForm.Nickname = txtName.Text;
            GameForm.Show();

        }
    }
}
