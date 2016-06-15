namespace VotingSystem
{
    partial class PartySelector
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
            this.voteBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // voteBox
            // 
            this.voteBox.FormattingEnabled = true;
            this.voteBox.Location = new System.Drawing.Point(13, 13);
            this.voteBox.Name = "voteBox";
            this.voteBox.Size = new System.Drawing.Size(259, 21);
            this.voteBox.TabIndex = 0;
            this.voteBox.SelectedIndexChanged += new System.EventHandler(this.voteBox_SelectedIndexChanged);
            // 
            // PartySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.voteBox);
            this.Name = "PartySelector";
            this.Text = "PartySelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox voteBox;
    }
}