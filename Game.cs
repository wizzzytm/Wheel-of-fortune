using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fare;

namespace KoloFortunyPL
{

    public partial class Game : Form
    {
        Random random = new Random();
        public string Nickname;
        public int[] Money = new int[] { 500, 500, 500, 500, 500, 500, 550, 600, 600, 650, 650, 700, 700, 700, 800, 800, 900, 900, 900, 900, 3500, 0, 0, 1 };
        List<PhraseClass> Phrases = new List<PhraseClass>();
        List<Player> Players = new List<Player>();
        private Settings settings;
        public TaskCompletionSource<bool> nextTurn;
        public TaskCompletionSource<bool> answerInput;
        Label label1 = new Label();
        private List<char> currentPhrase = new List<char>();
        private List<string> usedLetters = new List<string>();
        private int moneySpinned = 0;


        public Game()
        {

            InitializeComponent();
            this.Controls.Add(label1);
            Phrases = DBAccess.GetWords();
            settings = new Settings(this);
            Players.Add(new Player(Nickname));
            Players.Add(new Player("Krzysztof"));
            Players.Add(new Player("Andrzej"));
            Players.Add(new Player("Jurek"));
            Round();
        }

        private async void btnMoney_Click(object sender, EventArgs e)
        {
            
            btnMoney.Enabled = !btnMoney.Enabled;
            await Task.Run(() => ProcessMoney());


        }

        private void Round()
        {
            if (settings.RoundIndex == 3)
            {
                // koniec gry
            }
            else
            {
                lblRound.Text = $"Round {settings.RoundIndex+1}";
                settings.CurrentPhrase = Phrases.ElementAt(settings.RoundIndex).Phrase.ToUpper();
                settings.CurrentCategory = Phrases.ElementAt(settings.RoundIndex).Category;
                lblCategory.Text = settings.CurrentCategory;
                Phrase();
                Debug.WriteLine(settings.CurrentPhrase);
                lblTurn.Text = $"Your turn";
            }
            
        }

        private async void btnGuessOrVowel_Click(object sender, EventArgs e)
        {
            if (sender == btnGuess)
            {
                if (!RegexCheck(txtLetter.Text, false))
                {
                    MessageBox.Show("Insert a consonant!");
                    return;

                }
                ChangeControls();
                LetterAnim(txtLetter.Text);
                if (CheckLetter(txtLetter.Text) == 0)
                {
                    await Task.Delay(2000);
                    CorrectOrNotAnim(true);
                    foreach (Panel x in panelGame.Controls)
                    {
                        foreach (LetterLabel y in x.Controls)
                        {
                            if (y.Tag.ToString() == txtLetter.Text)
                            {
                                Players.ElementAt(settings.TurnIndex).RoundMoney += moneySpinned;
                                y.Text = txtLetter.Text;
                            }
                        }
                    }

                    txtLetter.Clear();
                }
                else if (CheckLetter(txtLetter.Text) == 1)
                {
                    await Task.Delay(2000);
                    CorrectOrNotAnim(false);
                    settings.TurnChange();
                }
            }
            else if (sender == btnVowel)
            {
                if (Players.ElementAt(settings.TurnIndex).RoundMoney < 250)
                {
                    MessageBox.Show("Not enough money to buy a vowel");
                    return;
                }
                if (!RegexCheck(txtLetter.Text, true))
                {
                    return;

                }
                ChangeControls();
                LetterAnim(txtLetter.Text);
                if (CheckLetter(txtLetter.Text) == 0)
                {
                    Players.ElementAt(settings.TurnIndex).RoundMoney -= 250;
                    await Task.Delay(2000);
                    CorrectOrNotAnim(true);
                    foreach (Panel x in panelGame.Controls)
                    {
                        foreach (LetterLabel y in x.Controls)
                        {
                            if (y.Tag.ToString() == txtLetter.Text)
                            {

                                y.Text = txtLetter.Text;
                            }
                        }
                    }

                    txtLetter.Clear();

                }
                else if (CheckLetter(txtLetter.Text) == 1)
                {
                    await Task.Delay(2000);
                    CorrectOrNotAnim(false);
                    settings.TurnChange();
                }
            }
            else if (sender == btnAnswer)
            {

                Input input = new Input(this);
                input.Show();
                Hide();
                answerInput = new TaskCompletionSource<bool>();
                await Task.Run(() => answerInput.Task);
                if (CheckPhrase(Input.Answer))
                {
                    settings.RoundChange();
                    ChangeControls();
                }
                else
                {
                    settings.TurnChange();
                }

            }

        }
        string regexBot = "^[^aeiouyAEIOUY\\u0100-\\u017F\\W\\d_]+$";
        public async void BotRound()
        {
            foreach(Control c in panelControls.Controls)
            {
                c.Enabled = false;
            }
            await Task.Run(() => ProcessMoney());
            string letter;
            Xeger xeger = new Xeger(regexBot, new Random());

            do
            {
                letter = xeger.Generate();
            }
            while (usedLetters.Contains(letter));
            

            do
            {
                LetterAnim(letter);
                if(CheckLetter(letter) == 0)
                {
                    await Task.Delay(2000);
                    CorrectOrNotAnim(true);
                    foreach (Panel x in panelGame.Controls)
                    {
                        foreach (LetterLabel y in x.Controls)
                        {
                            if (y.Tag.ToString() == letter)
                            {
                                Players.ElementAt(settings.TurnIndex).RoundMoney += moneySpinned;
                                y.Text = txtLetter.Text;
                            }
                        }
                    }
                }
                else if(CheckLetter(letter) == 1)
                {
                    await Task.Delay(2000);
                    CorrectOrNotAnim(false);
                    settings.TurnChange();
                    break;
                }
            }
            while (true);

        }
















        private async Task ProcessMoney()
        {
            moneySpinned = Money[random.Next(Money.Length)];
            lblMoney.Text = "Spinning the wheel";


            for (int i = 0; i < 6; i++)
            {
                await Task.Delay(500);
                lblMoney.Text += ".";
                if (i == 3)
                {
                    lblMoney.Text = "Spinning the wheel";
                }
            }
            lblMoney.Text = moneySpinned.ToString();
            if (moneySpinned == 0)
            {
                Players.ElementAt(settings.TurnIndex).RoundMoney = 0;
                settings.TurnChange();
            }
            else if (moneySpinned == 1)
            {
                settings.TurnChange();
            }
            else
            {
                Players.ElementAt(settings.TurnIndex).RoundMoney = moneySpinned;
            }
        }

        private async void CorrectOrNotAnim(bool correct)
        {
            
            var text = "\u2713";
            var colora = Color.Green;
            if (!correct)
            {
                colora = Color.Red;
                text = "X";
            }
            label1.Font = new Font("Microsoft Sans Serif", 36.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            label1.ForeColor = colora;

            for (int i = 0; i < 3; i++)
            {
                label1.Text = text;
                await Task.Delay(200);
                label1.Text = "";
                await Task.Delay(200);
            }
            label1.Text = text;
            await Task.Delay(400);
            label1.ForeColor = DefaultForeColor;
            label1.Visible = false;
            if(correct)
            {
                btnMoney.Enabled = true;
            }
        }

        public void LetterAnim(string letter)
        {
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            label1.Location = new Point(540, 710);
            label1.Name = "label1";
            label1.Size = new Size(70, 70);
            label1.TabIndex = 100;
            label1.Text = letter;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = true;
            label1.BringToFront();
            timerAnim.Start();
        }

        private bool RegexCheck(string input, bool vow)
        {
            Regex regexVow = new Regex("^[aeiouyAEIOUY]+$");
            Regex regexCons = new Regex("^[^aeiouyAEIOUY\\u0100-\\u017F\\W\\d_]+$");

                if (vow)
                {
                    if (!regexVow.IsMatch(input))
                    {
                        MessageBox.Show("Please insert a valid vowel", "", MessageBoxButtons.OK);
                        return false;
                    }
                    return true;
                }
                else
                {
                    if (!regexCons.IsMatch(input))
                    {
                        MessageBox.Show("Not valid input - please enter a consonant.", "", MessageBoxButtons.OK);
                        return false;
                    }
                    return true;
                }

            }







        private void Phrase()
        {
            string[] words = settings.CurrentPhrase.Split(' ');
            currentPhrase = settings.CurrentPhrase.ToCharArray().ToList();
            foreach(var x in currentPhrase)
            {
                Char.ToUpper(x);
            }

            foreach(string word in words)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.AutoSize = true;
                panel.BorderStyle = BorderStyle.FixedSingle;
                
                foreach (char c in word)
                {
                    
                    LetterLabel label = new LetterLabel();
                    if (c == ' ')
                    {
                        label.BackColor = Color.Transparent;
                        label._BorderStyle = BorderStyle.None;

                    }
                    else
                    {

                        label.Tag = c;
                        label.Text = "";

                    }
                    label.Text = "";
                    panel.Controls.Add(label);
                }
                panelGame.Controls.Add(panel);
                

            }

        }

        private int CheckLetter(string input)
        {
            if (!usedLetters.Contains(input))
            {
                if (currentPhrase.Contains(Char.Parse(input)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("Letter already used! Next turn.", "", MessageBoxButtons.OK);
                settings.TurnChange();
                usedLetters.Add(input);
                return 2;
            }
            
        }

        private bool CheckPhrase(string input)
        {
            input = String.Concat(input.ToUpper().Where(c => !Char.IsWhiteSpace(c)));
            var x = String.Concat(settings.CurrentPhrase.Where(c => !Char.IsWhiteSpace(c)));
            if(x == input)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangeControls()
        {
            btnAnswer.Enabled = !btnAnswer.Enabled;
            txtLetter.Enabled = !txtLetter.Enabled;
            btnGuess.Enabled = !btnGuess.Enabled;
            btnVowel.Enabled = !btnVowel.Enabled;
        }

        private  void timerAnim_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine($"Y-coordinate: {label1.Location.Y}");
            if (label1.Location.Y <= 320)
            {
                timerAnim.Stop();
            }
            else
            {

                label1.Location = new Point(label1.Location.X, label1.Location.Y - 8);
            }
        }
    }
}