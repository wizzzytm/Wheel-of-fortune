namespace WheelOfFortune
{
    partial class WheelExceptionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWheelEx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWheelEx
            // 
            this.lblWheelEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWheelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWheelEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWheelEx.ForeColor = System.Drawing.Color.White;
            this.lblWheelEx.Location = new System.Drawing.Point(0, 0);
            this.lblWheelEx.Name = "lblWheelEx";
            this.lblWheelEx.Size = new System.Drawing.Size(1200, 800);
            this.lblWheelEx.TabIndex = 0;
            this.lblWheelEx.Text = "Bancrupt/stop";
            this.lblWheelEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WheelExceptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWheelEx);
            this.Name = "WheelExceptionControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWheelEx;
    }
}
