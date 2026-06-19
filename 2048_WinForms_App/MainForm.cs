

using _2048_Core;

namespace _2048_WinForms_App
{
    public partial class MainForm : Form
    {
        private int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore = 0;
        private string userName;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.ShowDialog();
            userName = startForm.userNameTextBox.Text;

            CalculateMapSize(startForm.radioButtons);
            InitMap();
            GenerateNumber();
            ShowScore();
            CalculateBestScore();

        }

        private void CalculateMapSize(List<RadioButton> radioButtons)
        {
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    mapSize = int.Parse(radioButton.Text[0].ToString());
                    break;
                }
            }
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = GetStartingNumber().ToString();
                    break;
                }

                int GetStartingNumber()
                {
                    var randomNumber = random.Next(1, 101);
                    int result = randomNumber <= 75 ? 2 : 4;
                    return result;
                }
            }
        }
        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        private void ShowBestScore()
        {
            if (score > bestScore)
            {
                bestScore = score;
            }
            bestScoreLabel.Text = bestScore.ToString();
        }
        private void CalculateBestScore()
        {
            var users = UserManager.GetAll();

            if (users.Count == 0)
                return;

            bestScore = users.Max(u => u.Score);
            bestScoreLabel.Text = bestScore.ToString();

            ShowBestScore();
        }
        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = Color.RosyBrown;
            label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Name = "label";
            label.Size = new Size(60, 60);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 340 + indexColumn * 66;
            int y = 190 + indexRow * 66;
            label.Location = new Point(x, y);
            label.BringToFront();

            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;

            switch (label.Text)
            {
                case "": label.BackColor = Color.RosyBrown; break;
                case "2": label.BackColor = Color.FromArgb(238, 228, 218); break;
                case "4": label.BackColor = Color.FromArgb(237, 224, 200); break;
                case "8": label.BackColor = Color.FromArgb(242, 177, 121); break;
                case "16": label.BackColor = Color.FromArgb(245, 149, 99); break;
                case "32": label.BackColor = Color.FromArgb(246, 124, 95); break;
                case "64": label.BackColor = Color.FromArgb(246, 94, 59); break;
                case "128": label.BackColor = Color.FromArgb(237, 207, 114); break;
                case "256": label.BackColor = Color.FromArgb(237, 204, 97); break;
                case "512": label.BackColor = Color.FromArgb(237, 200, 80); break;
                case "1024": label.BackColor = Color.FromArgb(237, 197, 63); break;
                case "2048": label.BackColor = Color.FromArgb(237, 194, 46); break;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }

            GenerateNumber();
            ShowScore();
            ShowBestScore();

            if (Win())
            {
                SaveUserResults();
                MessageBox.Show("Hooray! You have won!");
                Close();
            }

            if (EndGame())
            {
                SaveUserResults();
                MessageBox.Show("Unfortunately, you have lost :(");
                Close();
            }
        }

        private void SaveUserResults()
        {
            UserManager.Add(new User() { Name = userName, Score = score });
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }

                }
            }
        }
        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }

                }
            }
        }

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if ((labelsMap[i, j].Text == labelsMap[i, j + 1].Text) || (labelsMap[i + 1, j].Text == labelsMap[i + 1, j].Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRulesForm = new GameRulesForm();
            gameRulesForm.ShowDialog();
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUserResults();
            Close();
        }
        private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

    }
}
