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
    public partial class Input : Form
    {
        public static string Answer;
        private Game game;
        public Input(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Answer = String.Concat(txtAnswer.Text.ToUpper().Where(c => !Char.IsWhiteSpace(c)));
            Game.answerInput?.TrySetResult(true);
            game.Show();
            Close();
        }
    }
}
