using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoloFortunyPL
{

    public partial class Game : Form
    {
        Random random = new Random();
        public int Turn = 0;
        public string Nickname;
        public int[] Money = new int[] { 500, 500, 500, 500, 500, 500, 550, 600, 600, 650, 650, 700, 700, 700, 800, 800, 900, 900, 900, 900, 3500, 0, 0, 1 };
        
        List<Phrase> Phrases = new List<Phrase>();

        public Game()
        {

            InitializeComponent();
            Phrases = DBAccess.GetWords();
            Player player = new Player(Nickname);
            Player bot1 = new Player("Bot Andrzej");
            Player bot2 = new Player("Bot Darek");
            Player bot3 = new Player("Bot Krzysztof");

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            Draw();
            btnMoney.Enabled = false;
            btnMoney.ForeColor = Color.DimGray;
            btnMoney.BackColor = Color.LightGreen;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            RegexCheck(txtLetter.Text);
        }

        private void btnVowel_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {

        }
        private void Draw()
        {
            int value = random.Next(Money.Length);
            if(value == 0)
            {
                Bancrupt();
            }
            else if(value == 1)
            {
                Round();
            }

        }

        private void RegexCheck(string input)
        {
            Regex regex = new Regex("^[^aeiouyAEIOUY\\u0100-\\u017F\\W\\d_]+$");
            if (!regex.IsMatch(input))
            {
                MessageBox.Show("Not valid input - please enter a consonant.", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Guessing(input);
            }
        }

        private void Guessing(string input)
        {

        }

        private void Bancrupt()
        {

        }
        private void Round()
        {

        }
    }
}
