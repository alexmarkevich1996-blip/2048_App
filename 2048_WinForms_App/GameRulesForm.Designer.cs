namespace _2048_WinForms_App
{
    partial class GameRulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRulesForm));
            gameRulesTextLabel = new Label();
            gameRulesTitleLabel = new Label();
            returnToMenuButton = new Button();
            SuspendLayout();
            // 
            // gameRulesTextLabel
            // 
            gameRulesTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameRulesTextLabel.Location = new Point(62, 141);
            gameRulesTextLabel.Name = "gameRulesTextLabel";
            gameRulesTextLabel.Size = new Size(685, 123);
            gameRulesTextLabel.TabIndex = 0;
            gameRulesTextLabel.Text = resources.GetString("gameRulesTextLabel.Text");
            gameRulesTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gameRulesTitleLabel
            // 
            gameRulesTitleLabel.AutoSize = true;
            gameRulesTitleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameRulesTitleLabel.Location = new Point(73, 120);
            gameRulesTitleLabel.Name = "gameRulesTitleLabel";
            gameRulesTitleLabel.Size = new Size(109, 21);
            gameRulesTitleLabel.TabIndex = 1;
            gameRulesTitleLabel.Text = "GAME RULES:";
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.BackColor = Color.FromArgb(255, 128, 128);
            returnToMenuButton.Location = new Point(631, 384);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(116, 43);
            returnToMenuButton.TabIndex = 2;
            returnToMenuButton.Text = "Return To Menu";
            returnToMenuButton.UseVisualStyleBackColor = false;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // GameRulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnToMenuButton);
            Controls.Add(gameRulesTitleLabel);
            Controls.Add(gameRulesTextLabel);
            Name = "GameRulesForm";
            Text = "GameRulesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameRulesTextLabel;
        private Label gameRulesTitleLabel;
        private Button returnToMenuButton;
    }
}