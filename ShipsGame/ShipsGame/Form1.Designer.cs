namespace ShipsGame
{
    partial class Form1
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
            label1 = new Label();
            tbxRows = new TextBox();
            tbxCols = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCheck = new Button();
            level = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(217, 41);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Board size";
            // 
            // tbxRows
            // 
            tbxRows.Location = new Point(217, 130);
            tbxRows.Name = "tbxRows";
            tbxRows.Size = new Size(151, 27);
            tbxRows.TabIndex = 1;
            // 
            // tbxCols
            // 
            tbxCols.Location = new Point(217, 163);
            tbxCols.Name = "tbxCols";
            tbxCols.Size = new Size(151, 27);
            tbxCols.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 163);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "columns";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 133);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "rows";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Image = Properties.Resources.check2;
            btnCheck.Location = new Point(274, 281);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(53, 44);
            btnCheck.TabIndex = 5;
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += button1_Click;
            // 
            // level
            // 
            level.FormattingEnabled = true;
            level.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Extreme" });
            level.Location = new Point(217, 196);
            level.Name = "level";
            level.Size = new Size(151, 28);
            level.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 199);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 7;
            label4.Text = "level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 78);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 8;
            label5.Text = "Size should be at least 3x3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 349);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(level);
            Controls.Add(btnCheck);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxCols);
            Controls.Add(tbxRows);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxRows;
        private TextBox tbxCols;
        private Label label2;
        private Label label3;
        private Button btnCheck;
        private ComboBox level;
        private Label label4;
        private Label label5;
    }
}