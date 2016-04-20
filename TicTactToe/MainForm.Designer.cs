namespace TicTactToe
{
    partial class MainForm
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
            this.singleplayerButton = new System.Windows.Forms.Button();
            this.mutliplayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplayerButton
            // 
            this.singleplayerButton.Location = new System.Drawing.Point(12, 12);
            this.singleplayerButton.Name = "singleplayerButton";
            this.singleplayerButton.Size = new System.Drawing.Size(260, 32);
            this.singleplayerButton.TabIndex = 0;
            this.singleplayerButton.Text = "Player vs. AI";
            this.singleplayerButton.UseVisualStyleBackColor = true;
            this.singleplayerButton.Click += new System.EventHandler(this.singleplayerButton_Click);
            // 
            // mutliplayerButton
            // 
            this.mutliplayerButton.Location = new System.Drawing.Point(12, 50);
            this.mutliplayerButton.Name = "mutliplayerButton";
            this.mutliplayerButton.Size = new System.Drawing.Size(260, 32);
            this.mutliplayerButton.TabIndex = 1;
            this.mutliplayerButton.Text = "Player vs. Player";
            this.mutliplayerButton.UseVisualStyleBackColor = true;
            this.mutliplayerButton.Click += new System.EventHandler(this.multiplayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.mutliplayerButton);
            this.Controls.Add(this.singleplayerButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplayerButton;
        private System.Windows.Forms.Button mutliplayerButton;
    }
}