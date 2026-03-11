using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_WinForms_App
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void startNewGameButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            Hide();
            mainForm.ShowDialog();
            Show();
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readGameRulesButton_Click(object sender, EventArgs e)
        {
            var gameRulesForm = new GameRulesForm();
            Hide();
            gameRulesForm.ShowDialog();
            Show();
        }
    }
}
