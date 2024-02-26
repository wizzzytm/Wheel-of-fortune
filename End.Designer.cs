namespace WheelOfFortune
{
    partial class End
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWinOrLoss = new System.Windows.Forms.PictureBox();
            this.btnAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinOrLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWinner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWinner.Location = new System.Drawing.Point(2, 94);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(536, 46);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "Nick_gracza";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Winner:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbWinOrLoss
            // 
            this.pbWinOrLoss.Location = new System.Drawing.Point(195, 175);
            this.pbWinOrLoss.Name = "pbWinOrLoss";
            this.pbWinOrLoss.Size = new System.Drawing.Size(148, 137);
            this.pbWinOrLoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWinOrLoss.TabIndex = 7;
            this.pbWinOrLoss.TabStop = false;
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Lime;
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgain.Location = new System.Drawing.Point(195, 359);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(148, 71);
            this.btnAgain.TabIndex = 8;
            this.btnAgain.Text = "Play again!";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.pbWinOrLoss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pbWinOrLoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbWinOrLoss;
        private System.Windows.Forms.Button btnAgain;
    }
}