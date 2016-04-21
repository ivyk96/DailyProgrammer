namespace TicTactToe
{
    partial class GameForm
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.textXLabel = new System.Windows.Forms.Label();
            this.textOLabel = new System.Windows.Forms.Label();
            this.winXLabel = new System.Windows.Forms.Label();
            this.winOLabel = new System.Windows.Forms.Label();
            this.textTieLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
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
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(37, 32);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(50, 50);
            this.A1.TabIndex = 2;
            this.A1.Tag = "field";
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(118, 32);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(50, 50);
            this.A2.TabIndex = 3;
            this.A2.Tag = "field";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(199, 32);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(50, 50);
            this.A3.TabIndex = 4;
            this.A3.Tag = "field";
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(37, 103);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(50, 50);
            this.B1.TabIndex = 5;
            this.B1.Tag = "field";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(118, 103);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(50, 50);
            this.B2.TabIndex = 6;
            this.B2.Tag = "field";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(199, 103);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(50, 50);
            this.B3.TabIndex = 7;
            this.B3.Tag = "field";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(37, 176);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(50, 50);
            this.C1.TabIndex = 8;
            this.C1.Tag = "field";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(118, 176);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(50, 50);
            this.C2.TabIndex = 9;
            this.C2.Tag = "field";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(199, 176);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(50, 50);
            this.C3.TabIndex = 10;
            this.C3.Tag = "field";
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(67, 236);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(51, 13);
            this.turnLabel.TabIndex = 1;
            this.turnLabel.Text = "turnLabel";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(208, 236);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(64, 13);
            this.winnerLabel.TabIndex = 11;
            this.winnerLabel.Text = "winnerLabel";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(12, 262);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 24);
            this.restartButton.TabIndex = 12;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // textXLabel
            // 
            this.textXLabel.AutoSize = true;
            this.textXLabel.Location = new System.Drawing.Point(208, 258);
            this.textXLabel.Name = "textXLabel";
            this.textXLabel.Size = new System.Drawing.Size(44, 13);
            this.textXLabel.TabIndex = 13;
            this.textXLabel.Text = "Wins X:";
            // 
            // textOLabel
            // 
            this.textOLabel.AutoSize = true;
            this.textOLabel.Location = new System.Drawing.Point(208, 276);
            this.textOLabel.Name = "textOLabel";
            this.textOLabel.Size = new System.Drawing.Size(45, 13);
            this.textOLabel.TabIndex = 14;
            this.textOLabel.Text = "Wins O:";
            // 
            // winXLabel
            // 
            this.winXLabel.AutoSize = true;
            this.winXLabel.Location = new System.Drawing.Point(258, 258);
            this.winXLabel.Name = "winXLabel";
            this.winXLabel.Size = new System.Drawing.Size(13, 13);
            this.winXLabel.TabIndex = 15;
            this.winXLabel.Text = "0";
            // 
            // winOLabel
            // 
            this.winOLabel.AutoSize = true;
            this.winOLabel.Location = new System.Drawing.Point(258, 276);
            this.winOLabel.Name = "winOLabel";
            this.winOLabel.Size = new System.Drawing.Size(13, 13);
            this.winOLabel.TabIndex = 16;
            this.winOLabel.Text = "0";
            // 
            // textTieLabel
            // 
            this.textTieLabel.AutoSize = true;
            this.textTieLabel.Location = new System.Drawing.Point(208, 293);
            this.textTieLabel.Name = "textTieLabel";
            this.textTieLabel.Size = new System.Drawing.Size(30, 13);
            this.textTieLabel.TabIndex = 17;
            this.textTieLabel.Text = "Ties:";
            // 
            // tiesLabel
            // 
            this.tiesLabel.AutoSize = true;
            this.tiesLabel.Location = new System.Drawing.Point(258, 293);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(13, 13);
            this.tiesLabel.TabIndex = 18;
            this.tiesLabel.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 315);
            this.Controls.Add(this.tiesLabel);
            this.Controls.Add(this.textTieLabel);
            this.Controls.Add(this.winOLabel);
            this.Controls.Add(this.winXLabel);
            this.Controls.Add(this.textOLabel);
            this.Controls.Add(this.textXLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.playingLabel);
            this.Name = "GameForm";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playingLabel;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label textXLabel;
        private System.Windows.Forms.Label textOLabel;
        private System.Windows.Forms.Label winXLabel;
        private System.Windows.Forms.Label winOLabel;
        private System.Windows.Forms.Label textTieLabel;
        private System.Windows.Forms.Label tiesLabel;
    }
}