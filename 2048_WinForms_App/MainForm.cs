using _2048_Data;

namespace _2048_WinForms_App
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            ShowScore();

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

            return label;
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
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

            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k  = j + 1; k < mapSize; k++)
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
            if (e.KeyCode == Keys.Up)
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
                                    if (labelsMap[i, j].Text == labelsMap[k,j].Text)
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
            if (e.KeyCode == Keys.Down)
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

            GenerateNumber();
            ShowScore();
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
            Application.Exit();
        }

       
    }
}
