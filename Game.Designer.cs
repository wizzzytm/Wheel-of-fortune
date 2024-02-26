namespace WheelOfFortune
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGame = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnVowel = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnMoney = new System.Windows.Forms.Button();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.btnRound4 = new System.Windows.Forms.Button();
            this.btnRound3 = new System.Windows.Forms.Button();
            this.btnRound2 = new System.Windows.Forms.Button();
            this.btnRound1 = new System.Windows.Forms.Button();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.lblMoney4 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblMoney3 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblMoney2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblMoney1 = new System.Windows.Forms.Label();
            this.timerBot = new System.Windows.Forms.Timer(this.components);
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGame);
            this.panelMain.Controls.Add(this.lblRound);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Controls.Add(this.panelPlayers);
            this.panelMain.Location = new System.Drawing.Point(0, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 800);
            this.panelMain.TabIndex = 0;
            // 
            // panelGame
            // 
            this.panelGame.AutoScroll = true;
            this.panelGame.Location = new System.Drawing.Point(12, 175);
            this.panelGame.MaximumSize = new System.Drawing.Size(1158, 334);
            this.panelGame.Name = "panelGame";
            this.panelGame.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.panelGame.Size = new System.Drawing.Size(1158, 334);
            this.panelGame.TabIndex = 6;
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRound.Location = new System.Drawing.Point(12, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(212, 46);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Round 1";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Location = new System.Drawing.Point(12, 529);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(1158, 46);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "label1";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnNextRound);
            this.panelControls.Controls.Add(this.lblMoney);
            this.panelControls.Controls.Add(this.btnAnswer);
            this.panelControls.Controls.Add(this.btnVowel);
            this.panelControls.Controls.Add(this.btnGuess);
            this.panelControls.Controls.Add(this.txtLetter);
            this.panelControls.Controls.Add(this.btnMoney);
            this.panelControls.Location = new System.Drawing.Point(12, 597);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1158, 145);
            this.panelControls.TabIndex = 2;
            // 
            // btnNextRound
            // 
            this.btnNextRound.BackColor = System.Drawing.Color.Lime;
            this.btnNextRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRound.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNextRound.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNextRound.Location = new System.Drawing.Point(473, 42);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(197, 71);
            this.btnNextRound.TabIndex = 9;
            this.btnNextRound.Text = "Next round -->";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Visible = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney.Location = new System.Drawing.Point(218, 59);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 32);
            this.lblMoney.TabIndex = 8;
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Lime;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnswer.Location = new System.Drawing.Point(941, 42);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(123, 71);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Guess the Phrase!";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnVowel
            // 
            this.btnVowel.BackColor = System.Drawing.Color.Lime;
            this.btnVowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVowel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVowel.Location = new System.Drawing.Point(676, 42);
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.Size = new System.Drawing.Size(98, 71);
            this.btnVowel.TabIndex = 6;
            this.btnVowel.Text = "Buy Vowel (250)";
            this.btnVowel.UseVisualStyleBackColor = false;
            this.btnVowel.Click += new System.EventHandler(this.btnBuyVow);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.Lime;
            this.btnGuess.Enabled = false;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGuess.Location = new System.Drawing.Point(572, 42);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(98, 71);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuessCon);
            // 
            // txtLetter
            // 
            this.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetter.Enabled = false;
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLetter.Location = new System.Drawing.Point(448, 42);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Multiline = true;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(118, 71);
            this.txtLetter.TabIndex = 4;
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.Lime;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMoney.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoney.Location = new System.Drawing.Point(89, 42);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(123, 71);
            this.btnMoney.TabIndex = 3;
            this.btnMoney.Text = "Spin the wheel!";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // panelPlayers
            // 
            this.panelPlayers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlayers.BackgroundImage")));
            this.panelPlayers.Controls.Add(this.btnRound4);
            this.panelPlayers.Controls.Add(this.btnRound3);
            this.panelPlayers.Controls.Add(this.btnRound2);
            this.panelPlayers.Controls.Add(this.btnRound1);
            this.panelPlayers.Controls.Add(this.lblPlayer4);
            this.panelPlayers.Controls.Add(this.lblMoney4);
            this.panelPlayers.Controls.Add(this.lblPlayer3);
            this.panelPlayers.Controls.Add(this.lblMoney3);
            this.panelPlayers.Controls.Add(this.lblPlayer2);
            this.panelPlayers.Controls.Add(this.lblMoney2);
            this.panelPlayers.Controls.Add(this.lblPlayer1);
            this.panelPlayers.Controls.Add(this.lblMoney1);
            this.panelPlayers.Location = new System.Drawing.Point(55, 49);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(1115, 120);
            this.panelPlayers.TabIndex = 0;
            // 
            // btnRound4
            // 
            this.btnRound4.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRound4.Enabled = false;
            this.btnRound4.FlatAppearance.BorderSize = 0;
            this.btnRound4.Location = new System.Drawing.Point(849, 75);
            this.btnRound4.Name = "btnRound4";
            this.btnRound4.Size = new System.Drawing.Size(30, 30);
            this.btnRound4.TabIndex = 18;
            this.btnRound4.UseVisualStyleBackColor = false;
            // 
            // btnRound3
            // 
            this.btnRound3.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRound3.Enabled = false;
            this.btnRound3.FlatAppearance.BorderSize = 0;
            this.btnRound3.Location = new System.Drawing.Point(579, 75);
            this.btnRound3.Name = "btnRound3";
            this.btnRound3.Size = new System.Drawing.Size(30, 30);
            this.btnRound3.TabIndex = 17;
            this.btnRound3.UseVisualStyleBackColor = false;
            // 
            // btnRound2
            // 
            this.btnRound2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRound2.Enabled = false;
            this.btnRound2.FlatAppearance.BorderSize = 0;
            this.btnRound2.Location = new System.Drawing.Point(302, 75);
            this.btnRound2.Name = "btnRound2";
            this.btnRound2.Size = new System.Drawing.Size(30, 30);
            this.btnRound2.TabIndex = 14;
            this.btnRound2.UseVisualStyleBackColor = false;
            // 
            // btnRound1
            // 
            this.btnRound1.BackColor = System.Drawing.Color.Black;
            this.btnRound1.Enabled = false;
            this.btnRound1.FlatAppearance.BorderSize = 0;
            this.btnRound1.Location = new System.Drawing.Point(52, 75);
            this.btnRound1.Name = "btnRound1";
            this.btnRound1.Size = new System.Drawing.Size(30, 30);
            this.btnRound1.TabIndex = 13;
            this.btnRound1.UseVisualStyleBackColor = false;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer4.Location = new System.Drawing.Point(806, 16);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(116, 23);
            this.lblPlayer4.TabIndex = 10;
            this.lblPlayer4.Text = "Jurek";
            this.lblPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney4
            // 
            this.lblMoney4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney4.Location = new System.Drawing.Point(807, 49);
            this.lblMoney4.Name = "lblMoney4";
            this.lblMoney4.Size = new System.Drawing.Size(115, 23);
            this.lblMoney4.TabIndex = 11;
            this.lblMoney4.Text = "0";
            this.lblMoney4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer3.Location = new System.Drawing.Point(537, 16);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(116, 23);
            this.lblPlayer3.TabIndex = 10;
            this.lblPlayer3.Text = "Andrzej";
            this.lblPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney3
            // 
            this.lblMoney3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney3.Location = new System.Drawing.Point(538, 49);
            this.lblMoney3.Name = "lblMoney3";
            this.lblMoney3.Size = new System.Drawing.Size(115, 23);
            this.lblMoney3.TabIndex = 11;
            this.lblMoney3.Text = "0";
            this.lblMoney3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer2.Location = new System.Drawing.Point(261, 16);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(116, 23);
            this.lblPlayer2.TabIndex = 10;
            this.lblPlayer2.Text = "Krzysztof";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney2
            // 
            this.lblMoney2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney2.Location = new System.Drawing.Point(262, 49);
            this.lblMoney2.Name = "lblMoney2";
            this.lblMoney2.Size = new System.Drawing.Size(115, 23);
            this.lblMoney2.TabIndex = 11;
            this.lblMoney2.Text = "0";
            this.lblMoney2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayer1.Location = new System.Drawing.Point(10, 16);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(116, 23);
            this.lblPlayer1.TabIndex = 7;
            this.lblPlayer1.Text = "label2";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney1
            // 
            this.lblMoney1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney1.Location = new System.Drawing.Point(11, 49);
            this.lblMoney1.Name = "lblMoney1";
            this.lblMoney1.Size = new System.Drawing.Size(115, 23);
            this.lblMoney1.TabIndex = 8;
            this.lblMoney1.Text = "0";
            this.lblMoney1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerAnim
            // 
            this.timerAnim.Enabled = true;
            this.timerAnim.Interval = 20;
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.panelMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelPlayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnVowel;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Timer timerBot;
        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.FlowLayoutPanel panelGame;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnRound4;
        private System.Windows.Forms.Button btnRound3;
        private System.Windows.Forms.Button btnRound2;
        private System.Windows.Forms.Button btnRound1;
        public System.Windows.Forms.Label lblMoney4;
        public System.Windows.Forms.Label lblMoney3;
        public System.Windows.Forms.Label lblMoney2;
        public System.Windows.Forms.Label lblMoney1;
    }
}