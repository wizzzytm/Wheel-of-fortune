namespace KoloFortunyPL
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnVowel = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnMoney = new System.Windows.Forms.Button();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.timerBot = new System.Windows.Forms.Timer(this.components);
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.panelGame = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelGame);
            this.panelMain.Controls.Add(this.lblTurn);
            this.panelMain.Controls.Add(this.lblRound);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Controls.Add(this.panelPlayers);
            this.panelMain.Location = new System.Drawing.Point(0, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 800);
            this.panelMain.TabIndex = 0;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurn.Location = new System.Drawing.Point(161, 15);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(91, 25);
            this.lblTurn.TabIndex = 5;
            this.lblTurn.Text = "Your turn";
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
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoney.Location = new System.Drawing.Point(240, 65);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 25);
            this.lblMoney.TabIndex = 8;
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Lime;
            this.btnAnswer.Enabled = false;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnswer.Location = new System.Drawing.Point(941, 42);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(123, 71);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Guess the Phrase!";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnGuessOrVowel_Click);
            // 
            // btnVowel
            // 
            this.btnVowel.BackColor = System.Drawing.Color.Lime;
            this.btnVowel.Enabled = false;
            this.btnVowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVowel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVowel.Location = new System.Drawing.Point(676, 42);
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.Size = new System.Drawing.Size(98, 71);
            this.btnVowel.TabIndex = 6;
            this.btnVowel.Text = "Buy Vowel (250)";
            this.btnVowel.UseVisualStyleBackColor = false;
            this.btnVowel.Click += new System.EventHandler(this.btnGuessOrVowel_Click);
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
            this.btnGuess.Click += new System.EventHandler(this.btnGuessOrVowel_Click);
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
            this.panelPlayers.Location = new System.Drawing.Point(12, 49);
            this.panelPlayers.Name = "panelPlayers";
            this.panelPlayers.Size = new System.Drawing.Size(1158, 120);
            this.panelPlayers.TabIndex = 0;
            // 
            // timerAnim
            // 
            this.timerAnim.Enabled = true;
            this.timerAnim.Interval = 20;
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
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
            this.panelMain.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
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
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.FlowLayoutPanel panelGame;
    }
}