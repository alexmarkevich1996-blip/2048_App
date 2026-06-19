using _2048_Core;
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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsDataGridView_Load(object sender, EventArgs e)
        {
            var users = UserManager.GetAll();

            var displayData = users.Select(u => new { u.Name, u.Score }).ToList();

            resultsDataGridView.DataSource = displayData;
        }
    }
}
