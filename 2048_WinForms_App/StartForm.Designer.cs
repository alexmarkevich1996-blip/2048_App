namespace _2048_WinForms_App
{
    partial class StartForm
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
            chooseTheSizeLagel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label1 = new Label();
            userNameTextBox = new TextBox();
            startGameButton = new Button();
            SuspendLayout();
            // 
            // chooseTheSizeLagel
            // 
            chooseTheSizeLagel.AutoSize = true;
            chooseTheSizeLagel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseTheSizeLagel.Location = new Point(56, 20);
            chooseTheSizeLagel.Name = "chooseTheSizeLagel";
            chooseTheSizeLagel.Size = new Size(226, 21);
            chooseTheSizeLagel.TabIndex = 0;
            chooseTheSizeLagel.Text = "Choose the size of game field";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(69, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "4 x 4";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(209, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 25);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "5 x 5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(69, 143);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 25);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "6 x 6";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(209, 143);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(62, 25);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "7 x 7";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 221);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 5;
            label1.Text = "Enter your name";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(61, 265);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(210, 23);
            userNameTextBox.TabIndex = 6;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = Color.MediumSeaGreen;
            startGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameButton.Location = new Point(136, 340);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(173, 34);
            startGameButton.TabIndex = 7;
            startGameButton.Text = "Start the Game";
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += startGameButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(457, 400);
            Controls.Add(startGameButton);
            Controls.Add(userNameTextBox);
            Controls.Add(label1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(chooseTheSizeLagel);
            Name = "StartForm";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chooseTheSizeLagel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label1;
        public TextBox userNameTextBox;
        private Button startGameButton;
    }
}