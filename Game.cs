using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fare;
using WheelOfFortune;

namespace KoloFortunyPL
{

    public partial class Game : Form
    {
        Random random = new Random();
        public string Nickname;
        public int[] Money = new int[] { 500, 500, 500, 500, 500, 500, 550, 600, 600, 650, 650, 700, 700, 700, 800, 800, 900, 900, 900, 900, 3500, 0, 0, 1 };
        List<PhraseClass> Phrases = new List<PhraseClass>();
        public string[] Letters = new string[]
        {
            "Q","W","R","T","P","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M"
        };
        public string[] Vowels = new string[]
        {
            "A", "E", "O", "U", "I", "Y"
        };
        public string[] VowelsRemaining = new string[]
        {
             "A", "E", "O", "U", "I", "Y"
        };
        List<Player> Players = new List<Player>();
        private Settings settings;
        public TaskCompletionSource<bool> answerInput;
        Label label1 = new Label();
        private List<char> currentPhrase = new List<char>();
        private List<string> usedLetters = new List<string>();
        private int moneySpinned = 0;
        private string inputValue;
        private int consLeft = 0;


        public Game(string nick)
        {
            this.Nickname = nick;
            InitializeComponent();
            this.Controls.Add(label1);
            Phrases = DBAccess.GetWords();
            PhraseClass test = new PhraseClass();
            test.Phrase = "Formula 1 racing";
            test.Category = "Sport";
            Phrases.Add(test);
            settings = new Settings(this);
            Players.Add(new Player(Nickname));
            Players.Add(new Player("Krzysztof"));
            Players.Add(new Player("Andrzej"));
            Players.Add(new Player("Jurek"));
            Debug.WriteLine($"Nick: {Nickname}");
            lblPlayer1.Text = Nickname;
            Round();
        }

        private async void btnMoney_Click(object sender, EventArgs e)
        {
            DisableAll();
            if (await ProcessMoney())
            {
                DisableBtn();
                return;
            }

            DisableBtn();
        }


        public void Round()
        {
            if (settings.RoundIndex == 3)
            {
                MessageBox.Show("KONIEC");
            }
            else
            {
                usedLetters.Clear();
                panelGame.Controls.Clear();
                lblRound.Text = $"Round {settings.RoundIndex + 1}";
                settings.CurrentPhrase = Phrases.ElementAt(settings.RoundIndex).Phrase.ToUpper();
                Debug.WriteLine(settings.CurrentPhrase);
                settings.CurrentCategory = Phrases.ElementAt(settings.RoundIndex).Category;
                lblCategory.Text = settings.CurrentCategory;
                Phrase();

            }

        }

        private async void btnBuyVow(object sender, EventArgs e)
        {
            if (Players.ElementAt(settings.TurnIndex).RoundMoney < 250)
            {
                MessageBox.Show("Not enough money to buy a vowel");
                return;
            }

            openInput(true);
            if (!RegexCheck(inputValue, 1))
            {
                return;
            }

            LetterAnim(inputValue);

            if (CheckLetter(inputValue) == 0)
            {
                Players.ElementAt(settings.TurnIndex).RoundMoney -= 250;
                await Task.Delay(2000);
                CorrectOrNotAnim(true);
                EnableBtn();

                foreach (Panel x in panelGame.Controls)
                {
                    foreach (LetterLabel y in x.Controls)
                    {
                        if (y.Tag.ToString() == inputValue)
                        {
                            y.Text = inputValue;
                        }
                    }
                }
                UpdateMoney();
                txtLetter.Clear();
                usedLetters.Add(inputValue);
            }
            else if (CheckLetter(inputValue) == 1)
            {
                await Task.Delay(2000);
                CorrectOrNotAnim(false);
                usedLetters.Add(inputValue);
                settings.TurnChange();
            }
        }



        private void openInput(bool ez)
        {
            Input inputForm = new Input(ez);
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                inputValue = inputForm.InputValue;
            }
            
        }

        private async void btnGuessCon(object sender, EventArgs e)
        {
            if (!RegexCheck(txtLetter.Text, 0))
            {
                MessageBox.Show("Insert a consonant!");
                return;
            }

            LetterAnim(txtLetter.Text);

            await Task.Run(() =>
            {
                int letterCheckResult = CheckLetter(txtLetter.Text);

                this.Invoke((MethodInvoker)async delegate
                {
                    if (letterCheckResult == 0)
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

                        UpdateMoney();
                        txtLetter.Clear();
                        EnableBtn();
                    }
                    else if (letterCheckResult == 1)
                    {
                        await Task.Delay(2000);
                        CorrectOrNotAnim(false);
                        txtLetter.Clear();
                        settings.TurnChange();
                    }
                });
            });

            usedLetters.Add(txtLetter.Text);
            CheckCons();
        }



        private void CheckCons()
        {
            foreach (var x in currentPhrase)
            {
                if (RegexCheck(x.ToString(), 2))
                {
                    if (currentPhrase.Contains(x))
                    {
                        consLeft++;
                    }
                }
            }
            if (consLeft == 0)
            {
                AnswerTime();
            }
        }



        public async void BotRound()
        {
            DisableAll();
            string letter;

            do
            {
                Debug.WriteLine(settings.TurnIndex);

                // Check if a bankrupt occurred during wheel spinning
                if (await ProcessMoney())
                {
                    return;
                }

                do
                {
                    letter = Letters[random.Next(0, Letters.Length)];
                }
                while (usedLetters.Contains(letter));

                LetterAnim(letter);

                if (CheckLetter(letter) == 0)
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
                                y.Text = letter;
                            }
                        }
                    }
                }
                else if (CheckLetter(letter) == 1)
                {
                    break;
                }
            }
            while (true);

            await Task.Delay(2000);
            CorrectOrNotAnim(false);
            settings.TurnChange();
        }


        private void DisableAll()
        {
            foreach (Control c in panelControls.Controls)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    c.Enabled = false;
                });
               
            }
            
        }

        private void DiasbleAll()
        {
            foreach (Control c in panelControls.Controls)
            {
                c.Invoke((MethodInvoker)delegate
                {
                    c.Enabled = false;
                });
            }
        }

        private void UpdateMoney()
        {
            this.Invoke((MethodInvoker)delegate
            {
                switch (settings.TurnIndex)
                {
                    case 0:
                        lblMoney1.Text = Players.ElementAt(settings.TurnIndex).RoundMoney.ToString();
                        break;
                    case 1:
                        lblMoney2.Text = Players.ElementAt(settings.TurnIndex).RoundMoney.ToString();
                        break;
                    case 2:
                        lblMoney3.Text = Players.ElementAt(settings.TurnIndex).RoundMoney.ToString();
                        break;
                    case 3:
                        lblMoney4.Text = Players.ElementAt(settings.TurnIndex).RoundMoney.ToString();
                        break;

                }
            });
           
        }

        private async Task<bool> ProcessMoney()
        {
            moneySpinned = Money[random.Next(Money.Length)];
            this.Invoke((MethodInvoker)delegate
            {
                lblMoney.Text = "Spinning the wheel";
            });

            for (int i = 0; i < 6; i++)
            {
                await Task.Delay(500);
                this.Invoke((MethodInvoker)delegate
                {
                    lblMoney.Text += ".";
                });
                if (i == 3)
                {
                    lblMoney.Invoke((MethodInvoker)delegate
                    {
                        lblMoney.Text = "Spinning the wheel";
                    });
                }
            }

            this.Invoke((MethodInvoker)delegate
            {
                lblMoney.Text = moneySpinned.ToString();
            });

            if (moneySpinned == 0)
            {
                Players.ElementAt(settings.TurnIndex).RoundMoney = 0;
                UpdateMoney();
                this.Invoke((MethodInvoker)async delegate
                {
                    WheelExceptionControl bancrupt = new WheelExceptionControl();
                    Controls.Add(bancrupt);
                    bancrupt.Text = "BANCRUPT";
                    bancrupt.Visible = true;
                    bancrupt.BringToFront();
                    bancrupt.Size = ClientSize;
                    Debug.WriteLine(bancrupt.Size);
                    await Task.Delay(1500);
                    Controls.Remove(bancrupt);
                });

                settings.TurnChange();
                return true;  // Indicates a bankrupt occurred
            }
            else if (moneySpinned == 1)
            {
                this.Invoke((MethodInvoker)async delegate
                {
                    WheelExceptionControl stop = new WheelExceptionControl();
                    Controls.Add(stop);
                    stop.Text = "STOP";
                    stop.Visible = true;
                    stop.BringToFront();
                    stop.Size = ClientSize;
                    Debug.WriteLine(stop.Size);
                    await Task.Delay(1500);
                    Controls.Remove(stop);
                });
                settings.TurnChange();
                return true;  // Indicates a stop occurred
            }

            return false;  // Indicates no exception occurred
        }

        private void AnswerTime()
        {

            foreach (Control c in panelControls.Controls)
            {
                c.Enabled = false;
            }
            
            if (settings.TurnIndex != 0)
            {
                HandleAnswer(() => botAnswer());

            }
            else
            {
                btnAnswer.Enabled = true;
                btnVowel.Enabled = true;
                if (VowelsRemaining.Length == 0)
                {
                    GoodAnswer();
                }
            }
           
        }

        private  void CorrectOrNotAnim(bool correct)
        {
            this.Invoke((MethodInvoker)async delegate
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
                await Task.Delay(300);
            });
            
        }

        public void LetterAnim(string letter)
        {
            this.Invoke((MethodInvoker)delegate
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
            });
        }

        private bool RegexCheck(string input, int op)
        {
            Regex regexVow = new Regex("^[aeiouyAEIOUY]+$");
            Regex regexCons = new Regex("^[^aeiouyAEIOUY\\u0100-\\u017F\\W\\d_]+$");

            if (op == 1)
            {
                if (!regexVow.IsMatch(input))
                {
                    MessageBox.Show("Please insert a valid vowel", "", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            else if (op == 0)
            {
                if (!regexCons.IsMatch(input))
                {
                    MessageBox.Show("Not valid input - please enter a consonant.", "", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            else
            {
                if (!regexCons.IsMatch(input))
                {
                    return false;
                }
                return true;
            }
        }

        private void Phrase()
        {
            string[] words = settings.CurrentPhrase.Split(' ');
            currentPhrase = settings.CurrentPhrase.ToCharArray().ToList();
            foreach (var x in currentPhrase)
            {
                char.ToUpper(x);
            }

            foreach (string word in words)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.AutoSize = true;
                panel.BorderStyle = BorderStyle.FixedSingle;

                foreach (char c in word)
                {

                    LetterLabel label = new LetterLabel();
                    if (char.IsWhiteSpace(c))
                    {
                        label.BackColor = Color.Transparent;
                        label._BorderStyle = BorderStyle.None;

                    }
                    else if(char.IsDigit(c))
                    {
                        label.Text = c.ToString();
                        
                    }
                    else
                    {

                        label.Tag = c;
                        label.Text = "";

                    }
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
                    currentPhrase.RemoveAll(c => c == Char.Parse(input));  // Remove all occurrences of the guessed letter
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
            if (x == input)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

       

        private void timerAnim_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y <= 320)
            {
                timerAnim.Stop();
            }
            else
            {

                label1.Location = new Point(label1.Location.X, label1.Location.Y - 8);
            }
        }
        public void EnableBtn()
        {
            this.Invoke((MethodInvoker)delegate 
            {
                btnMoney.Enabled = true;
                btnAnswer.Enabled = true;
                btnVowel.Enabled = true;
                txtLetter.Enabled = false;
                btnGuess.Enabled = false;
            });
            
        }

        public void DisableBtn() 
        {
            this.Invoke((MethodInvoker)delegate
            {
                btnMoney.Enabled = false;
                btnAnswer.Enabled = false;
                btnVowel.Enabled = false;
                txtLetter.Enabled = true;
                btnGuess.Enabled = true;
            });
        }

        private void botAnswer()
        {
            settings.TurnIndex = random.Next(1, 4);
            GoodAnswer();
        }



        private void HandleAnswer(Action method)
        {
            openInput(false);
            inputValue.ToUpper().Where(c => !Char.IsWhiteSpace(c));
            if (CheckPhrase(inputValue))
            {
                GoodAnswer();
            }
            else
            {
                method.Invoke();
            }
        }

        public void CheckboxChange()
        {
            switch (settings.TurnIndex)
            {
                case 0:
                    btnRound4.BackColor = Color.Gainsboro;
                    btnRound1.BackColor = Color.Black;
                    break;
                case 1:
                    btnRound1.BackColor = Color.Gainsboro;
                    btnRound2.BackColor = Color.Black;
                    break;
                case 2:
                    btnRound2.BackColor = Color.Gainsboro;
                    btnRound3.BackColor = Color.Black;
                    break;
                case 3:
                    btnRound3.BackColor = Color.Gainsboro;
                    btnRound4.BackColor = Color.Black;
                    break;

            }
        }

        private void GoodAnswer()
        {
            foreach (Panel x in panelGame.Controls)
            {
                foreach (LetterLabel y in x.Controls)
                {
                    if (y.Tag != null)
                    {
                        y.Text = y.Tag.ToString();
                    }
                }
            }
            Players.ElementAt(settings.TurnIndex).Money += Players.ElementAt(settings.TurnIndex).RoundMoney;
            foreach (Control c in panelControls.Controls)
            {
                c.Visible = false;
            }
            btnNextRound.Visible = true;
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelControls.Controls)
            {
                c.Visible = true;
            }
            btnNextRound.Visible = false;
            settings.RoundChange();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            HandleAnswer(() => settings.TurnChange());
        }
    }
}