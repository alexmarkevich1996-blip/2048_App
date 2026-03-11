namespace _2048_WinForms_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            scoreTextLabel = new Label();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Location = new Point(61, 33);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(42, 15);
            scoreTextLabel.TabIndex = 0;
            scoreTextLabel.Text = "Score: ";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(128, 33);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 666);
            Controls.Add(scoreLabel);
            Controls.Add(scoreTextLabel);
            KeyPreview = true;
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreTextLabel;
        private Label scoreLabel;
    }
}
