namespace _2048_WinForms_App
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            scoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, scoreColumn });
            resultsDataGridView.Location = new Point(69, 41);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.Size = new Size(459, 197);
            resultsDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            // 
            // scoreColumn
            // 
            scoreColumn.HeaderText = "Score";
            scoreColumn.Name = "scoreColumn";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsDataGridView);
            Name = "ResultsForm";
            Text = "ResultsForm";
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn scoreColumn;
    }
}