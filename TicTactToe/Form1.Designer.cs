﻿namespace TicTactToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
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
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(37, 32);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(30, 30);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(118, 32);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(30, 30);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(199, 32);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(30, 30);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(37, 103);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(30, 30);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(118, 103);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(30, 30);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(199, 103);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(30, 30);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(37, 176);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(30, 30);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(118, 176);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(30, 30);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(199, 176);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(30, 30);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playingLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
    }
}

