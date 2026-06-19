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
    public partial class StartForm : Form
    {
        public List<RadioButton> radioButtons;
        public StartForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>
            {
                radioButton1, radioButton2, radioButton3, radioButton4
            };


        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
