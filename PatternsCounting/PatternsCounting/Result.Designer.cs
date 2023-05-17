namespace PatternsCounting
{
    partial class Result
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
            dgvCounter = new DataGridView();
            Sequence = new DataGridViewTextBoxColumn();
            Counts = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCounter).BeginInit();
            SuspendLayout();
            // 
            // dgvCounter
            // 
            dgvCounter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCounter.Columns.AddRange(new DataGridViewColumn[] { Sequence, Counts });
            dgvCounter.Location = new Point(173, 85);
            dgvCounter.Name = "dgvCounter";
            dgvCounter.RowHeadersWidth = 51;
            dgvCounter.RowTemplate.Height = 29;
            dgvCounter.Size = new Size(304, 188);
            dgvCounter.TabIndex = 0;
            dgvCounter.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Sequence
            // 
            Sequence.HeaderText = "Sequence";
            Sequence.MinimumWidth = 6;
            Sequence.Name = "Sequence";
            Sequence.Width = 125;
            // 
            // Counts
            // 
            Counts.HeaderText = "Counts";
            Counts.MinimumWidth = 6;
            Counts.Name = "Counts";
            Counts.Width = 125;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCounter);
            Name = "Result";
            Text = "Result";
            ((System.ComponentModel.ISupportInitialize)dgvCounter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCounter;
        private DataGridViewTextBoxColumn Sequence;
        private DataGridViewTextBoxColumn Counts;
    }
}