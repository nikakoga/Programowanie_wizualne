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
            buttonSEARCH = new Button();
            textBoxSEARCH = new TextBox();
            FirstName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSEARCH).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSEARCH
            // 
            dataGridViewSEARCH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSEARCH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSEARCH.Columns.AddRange(new DataGridViewColumn[] { FirstName, Surname, Year, Month, Day });
            dataGridViewSEARCH.Location = new Point(76, 128);
            dataGridViewSEARCH.Name = "dataGridViewSEARCH";
            dataGridViewSEARCH.RowHeadersWidth = 51;
            dataGridViewSEARCH.RowTemplate.Height = 29;
            dataGridViewSEARCH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSEARCH.Size = new Size(682, 284);
            dataGridViewSEARCH.TabIndex = 5;
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
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            // 
            // Month
            // 
            Month.HeaderText = "Month";
            Month.MinimumWidth = 6;
            Month.Name = "Month";
            // 
            // Day
            // 
            Day.HeaderText = "Day";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
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
        private Button buttonSEARCH;
        private TextBox textBoxSEARCH;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Day;
    }
}