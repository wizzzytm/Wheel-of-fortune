using System;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class Start : Form
    {
        private string nickname = "";

        public Start()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nickname))
            {
                Game gameForm = new Game(txtName.Text);
                gameForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter a nickname before starting the game.");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nickname = txtName.Text;
        }
    }
}