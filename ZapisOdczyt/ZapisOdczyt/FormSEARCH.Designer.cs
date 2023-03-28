namespace ZapisOdczyt
{
    partial class FormSEARCH
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
            dataGridViewSEARCH = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnMonth = new DataGridViewTextBoxColumn();
            ColumnDay = new DataGridViewTextBoxColumn();
            buttonSEARCH = new Button();
            textBoxSEARCH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSEARCH).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSEARCH
            // 
            dataGridViewSEARCH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSEARCH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSEARCH.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ColumnSurname, ColumnYear, ColumnMonth, ColumnDay });
            dataGridViewSEARCH.Location = new Point(76, 128);
            dataGridViewSEARCH.Name = "dataGridViewSEARCH";
            dataGridViewSEARCH.RowHeadersWidth = 51;
            dataGridViewSEARCH.RowTemplate.Height = 29;
            dataGridViewSEARCH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSEARCH.Size = new Size(682, 284);
            dataGridViewSEARCH.TabIndex = 5;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            // 
            // ColumnSurname
            // 
            ColumnSurname.HeaderText = "Surname";
            ColumnSurname.MinimumWidth = 6;
            ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnYear
            // 
            ColumnYear.HeaderText = "Year";
            ColumnYear.MinimumWidth = 6;
            ColumnYear.Name = "ColumnYear";
            // 
            // ColumnMonth
            // 
            ColumnMonth.HeaderText = "Month";
            ColumnMonth.MinimumWidth = 6;
            ColumnMonth.Name = "ColumnMonth";
            // 
            // ColumnDay
            // 
            ColumnDay.HeaderText = "Day";
            ColumnDay.MinimumWidth = 6;
            ColumnDay.Name = "ColumnDay";
            // 
            // buttonSEARCH
            // 
            buttonSEARCH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSEARCH.Location = new Point(544, 64);
            buttonSEARCH.Name = "buttonSEARCH";
            buttonSEARCH.Size = new Size(94, 29);
            buttonSEARCH.TabIndex = 6;
            buttonSEARCH.Text = "SEARCH";
            buttonSEARCH.UseVisualStyleBackColor = true;
            buttonSEARCH.Click += buttonSEARCH_Click;
            // 
            // textBoxSEARCH
            // 
            textBoxSEARCH.Location = new Point(174, 64);
            textBoxSEARCH.Name = "textBoxSEARCH";
            textBoxSEARCH.Size = new Size(323, 27);
            textBoxSEARCH.TabIndex = 7;
            // 
            // FormSEARCH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSEARCH);
            Controls.Add(buttonSEARCH);
            Controls.Add(dataGridViewSEARCH);
            Name = "FormSEARCH";
            Text = "FormSEARCH";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSEARCH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewSEARCH;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnMonth;
        private DataGridViewTextBoxColumn ColumnDay;
        private Button buttonSEARCH;
        private TextBox textBoxSEARCH;
    }
}