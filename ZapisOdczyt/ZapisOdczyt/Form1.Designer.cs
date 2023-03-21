namespace ZapisOdczyt
{
    partial class FormMAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonADD = new Button();
            buttonLOAD = new Button();
            buttonDELETE = new Button();
            buttonSAVE = new Button();
            dataGridView1 = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnYear = new DataGridViewTextBoxColumn();
            ColumnMonth = new DataGridViewTextBoxColumn();
            ColumnDay = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonADD
            // 
            buttonADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonADD.Location = new Point(41, 386);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(94, 29);
            buttonADD.TabIndex = 0;
            buttonADD.Text = "ADD";
            buttonADD.UseVisualStyleBackColor = true;
            buttonADD.Click += buttonADD_Click;
            // 
            // buttonLOAD
            // 
            buttonLOAD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLOAD.Location = new Point(629, 386);
            buttonLOAD.Name = "buttonLOAD";
            buttonLOAD.Size = new Size(94, 29);
            buttonLOAD.TabIndex = 1;
            buttonLOAD.Text = "LOAD";
            buttonLOAD.UseVisualStyleBackColor = true;
            // 
            // buttonDELETE
            // 
            buttonDELETE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDELETE.Location = new Point(239, 386);
            buttonDELETE.Name = "buttonDELETE";
            buttonDELETE.Size = new Size(94, 29);
            buttonDELETE.TabIndex = 2;
            buttonDELETE.Text = "DELETE";
            buttonDELETE.UseVisualStyleBackColor = true;
            // 
            // buttonSAVE
            // 
            buttonSAVE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSAVE.Location = new Point(434, 386);
            buttonSAVE.Name = "buttonSAVE";
            buttonSAVE.Size = new Size(94, 29);
            buttonSAVE.TabIndex = 3;
            buttonSAVE.Text = "SAVE";
            buttonSAVE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ColumnSurname, ColumnYear, ColumnMonth, ColumnDay });
            dataGridView1.Location = new Point(41, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(682, 284);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // FormMAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSAVE);
            Controls.Add(buttonDELETE);
            Controls.Add(buttonLOAD);
            Controls.Add(buttonADD);
            Name = "FormMAIN";
            Text = "FormMAIN";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonADD;
        private Button buttonLOAD;
        private Button buttonDELETE;
        private Button buttonSAVE;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnYear;
        private DataGridViewTextBoxColumn ColumnMonth;
        private DataGridViewTextBoxColumn ColumnDay;
    }
}