namespace _2048_WinForms_App
{
    partial class MenuForm
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
            startNewGameButton = new Button();
            ExitAppButton = new Button();
            readGameRulesButton = new Button();
            resultsButton = new Button();
            SuspendLayout();
            // 
            // startNewGameButton
            // 
            startNewGameButton.Location = new Point(318, 144);
            startNewGameButton.Name = "startNewGameButton";
            startNewGameButton.Size = new Size(168, 41);
            startNewGameButton.TabIndex = 0;
            startNewGameButton.Text = "Start New Game";
            startNewGameButton.UseVisualStyleBackColor = true;
            startNewGameButton.Click += startNewGameButton_Click;
            // 
            // ExitAppButton
            // 
            ExitAppButton.BackColor = Color.FromArgb(255, 128, 128);
            ExitAppButton.Location = new Point(318, 349);
            ExitAppButton.Name = "ExitAppButton";
            ExitAppButton.Size = new Size(168, 41);
            ExitAppButton.TabIndex = 1;
            ExitAppButton.Text = "Exit the Program";
            ExitAppButton.UseVisualStyleBackColor = false;
            ExitAppButton.Click += ExitAppButton_Click;
            // 
            // readGameRulesButton
            // 
            readGameRulesButton.Location = new Point(318, 216);
            readGameRulesButton.Name = "readGameRulesButton";
            readGameRulesButton.Size = new Size(168, 41);
            readGameRulesButton.TabIndex = 2;
            readGameRulesButton.Text = "Read Game Rules";
            readGameRulesButton.UseVisualStyleBackColor = true;
            readGameRulesButton.Click += readGameRulesButton_Click;
            // 
            // resultsButton
            // 
            resultsButton.Location = new Point(318, 282);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(168, 41);
            resultsButton.TabIndex = 3;
            resultsButton.Text = "Results";
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 595);
            Controls.Add(resultsButton);
            Controls.Add(readGameRulesButton);
            Controls.Add(ExitAppButton);
            Controls.Add(startNewGameButton);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button startNewGameButton;
        private Button ExitAppButton;
        private Button readGameRulesButton;
        private Button resultsButton;
    }
}