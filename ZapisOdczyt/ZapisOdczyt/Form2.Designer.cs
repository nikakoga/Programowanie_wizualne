namespace ZapisOdczyt
{
    partial class FormADD
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
            labelName = new Label();
            labelSurname = new Label();
            labelYearOfbirth = new Label();
            LabelMonthOfBirth = new Label();
            labelDayOfBirth = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(76, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(76, 107);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(67, 20);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Surname";
            // 
            // labelYearOfbirth
            // 
            labelYearOfbirth.AutoSize = true;
            labelYearOfbirth.Location = new Point(74, 175);
            labelYearOfbirth.Name = "labelYearOfbirth";
            labelYearOfbirth.Size = new Size(90, 20);
            labelYearOfbirth.TabIndex = 2;
            labelYearOfbirth.Text = "Year of birth";
            // 
            // LabelMonthOfBirth
            // 
            LabelMonthOfBirth.AutoSize = true;
            LabelMonthOfBirth.Location = new Point(76, 249);
            LabelMonthOfBirth.Name = "LabelMonthOfBirth";
            LabelMonthOfBirth.Size = new Size(105, 20);
            LabelMonthOfBirth.TabIndex = 3;
            LabelMonthOfBirth.Text = "Month of birth";
            // 
            // labelDayOfBirth
            // 
            labelDayOfBirth.AutoSize = true;
            labelDayOfBirth.Location = new Point(76, 333);
            labelDayOfBirth.Name = "labelDayOfBirth";
            labelDayOfBirth.Size = new Size(88, 20);
            labelDayOfBirth.TabIndex = 4;
            labelDayOfBirth.Text = "Day of birth";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(76, 63);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(76, 130);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(246, 27);
            textBoxSurname.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 287);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(77, 370);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // FormADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelDayOfBirth);
            Controls.Add(LabelMonthOfBirth);
            Controls.Add(labelYearOfbirth);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "FormADD";
            Text = "FormADD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelYearOfbirth;
        private Label LabelMonthOfBirth;
        private Label labelDayOfBirth;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}