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
            comboBoxMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            buttonADD = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(26, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(26, 107);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(67, 20);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Surname";
            // 
            // labelYearOfbirth
            // 
            labelYearOfbirth.AutoSize = true;
            labelYearOfbirth.Location = new Point(26, 173);
            labelYearOfbirth.Name = "labelYearOfbirth";
            labelYearOfbirth.Size = new Size(90, 20);
            labelYearOfbirth.TabIndex = 2;
            labelYearOfbirth.Text = "Year of birth";
            // 
            // LabelMonthOfBirth
            // 
            LabelMonthOfBirth.AutoSize = true;
            LabelMonthOfBirth.Location = new Point(306, 40);
            LabelMonthOfBirth.Name = "LabelMonthOfBirth";
            LabelMonthOfBirth.Size = new Size(105, 20);
            LabelMonthOfBirth.TabIndex = 3;
            LabelMonthOfBirth.Text = "Month of birth";
            LabelMonthOfBirth.Click += LabelMonthOfBirth_Click;
            // 
            // labelDayOfBirth
            // 
            labelDayOfBirth.AutoSize = true;
            labelDayOfBirth.Location = new Point(569, 40);
            labelDayOfBirth.Name = "labelDayOfBirth";
            labelDayOfBirth.Size = new Size(88, 20);
            labelDayOfBirth.TabIndex = 4;
            labelDayOfBirth.Text = "Day of birth";
            labelDayOfBirth.Click += labelDayOfBirth_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(26, 64);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(246, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(26, 130);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(246, 27);
            textBoxSurname.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 7;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(306, 64);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(203, 28);
            comboBoxMonth.TabIndex = 8;
            comboBoxMonth.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDay.Location = new Point(569, 63);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(88, 28);
            comboBoxDay.TabIndex = 9;
            // 
            // buttonADD
            // 
            buttonADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonADD.Location = new Point(88, 320);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(94, 29);
            buttonADD.TabIndex = 10;
            buttonADD.Text = "ADD";
            buttonADD.UseVisualStyleBackColor = true;
            // 
            // FormADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonADD);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxMonth);
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
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDay;
        private Button buttonADD;
    }
}