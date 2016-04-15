namespace TicTactToe
{
    partial class Form1
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
            this.playingLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playingLabel
            // 
            this.playingLabel.AutoSize = true;
            this.playingLabel.Location = new System.Drawing.Point(13, 236);
            this.playingLabel.Name = "playingLabel";
            this.playingLabel.Size = new System.Drawing.Size(47, 13);
            this.playingLabel.TabIndex = 0;
            this.playingLabel.Text = "Playing: ";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(67, 236);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(0, 13);
            this.turnLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.playingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playingLabel;
        private System.Windows.Forms.Label turnLabel;
    }
}

