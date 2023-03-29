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
            buttonSEARCH = new Button();
            FirstName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Month = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonADD
            // 
            buttonADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonADD.Location = new Point(41, 352);
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
            buttonLOAD.Location = new Point(165, 399);
            buttonLOAD.Name = "buttonLOAD";
            buttonLOAD.Size = new Size(94, 29);
            buttonLOAD.TabIndex = 1;
            buttonLOAD.Text = "LOAD";
            buttonLOAD.UseVisualStyleBackColor = true;
            buttonLOAD.Click += buttonLOAD_Click;
            // 
            // buttonDELETE
            // 
            buttonDELETE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDELETE.Location = new Point(41, 400);
            buttonDELETE.Name = "buttonDELETE";
            buttonDELETE.Size = new Size(94, 29);
            buttonDELETE.TabIndex = 2;
            buttonDELETE.Text = "DELETE";
            buttonDELETE.UseVisualStyleBackColor = true;
            buttonDELETE.Click += buttonDELETE_Click;
            // 
            // buttonSAVE
            // 
            buttonSAVE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSAVE.Location = new Point(165, 352);
            buttonSAVE.Name = "buttonSAVE";
            buttonSAVE.Size = new Size(94, 29);
            buttonSAVE.TabIndex = 3;
            buttonSAVE.Text = "SAVE";
            buttonSAVE.UseVisualStyleBackColor = true;
            buttonSAVE.Click += buttonSAVE_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, Surname, Year, Month, Day });
            dataGridView1.Location = new Point(41, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(682, 284);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSEARCH
            // 
            buttonSEARCH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSEARCH.Location = new Point(283, 352);
            buttonSEARCH.Name = "buttonSEARCH";
            buttonSEARCH.Size = new Size(94, 29);
            buttonSEARCH.TabIndex = 7;
            buttonSEARCH.Text = "SEARCH";
            buttonSEARCH.UseVisualStyleBackColor = true;
            buttonSEARCH.Click += buttonSEARCH_Click;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Name";
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
            // FormMAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSEARCH);
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
        public DataGridView dataGridView1;
        private Button buttonSEARCH;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn Day;
    }
}