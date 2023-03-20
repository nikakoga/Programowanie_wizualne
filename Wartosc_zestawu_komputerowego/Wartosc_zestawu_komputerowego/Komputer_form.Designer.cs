namespace Wartosc_zestawu_komputerowego
{
    partial class Komputer_form
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            Dysk_Label = new Label();
            label1 = new Label();
            label2 = new Label();
            Zapisz_button = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Fuchsia;
            checkBox1.Location = new Point(597, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Mysz";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.Fuchsia;
            checkBox2.Location = new Point(597, 158);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 29);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Kamerka";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.Fuchsia;
            checkBox3.Location = new Point(597, 188);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 29);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "CD-ROM";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.Fuchsia;
            checkBox4.Location = new Point(597, 218);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(110, 29);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "port USB";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Fuchsia;
            radioButton1.Location = new Point(90, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 29);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "0,5 TB";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Fuchsia;
            radioButton2.Location = new Point(90, 174);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 29);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "1 TB";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.Fuchsia;
            radioButton3.Location = new Point(90, 209);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 29);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "2 TB";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Dysk_Label
            // 
            Dysk_Label.AutoSize = true;
            Dysk_Label.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Dysk_Label.ForeColor = Color.Fuchsia;
            Dysk_Label.Location = new Point(101, 113);
            Dysk_Label.Name = "Dysk_Label";
            Dysk_Label.Size = new Size(51, 25);
            Dysk_Label.TabIndex = 8;
            Dysk_Label.Text = "Dysk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(308, 128);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 9;
            label1.Text = "0000,00zł";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(321, 103);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 10;
            label2.Text = "Cena :";
            label2.Click += label2_Click;
            // 
            // Zapisz_button
            // 
            Zapisz_button.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Zapisz_button.ForeColor = Color.Fuchsia;
            Zapisz_button.Location = new Point(597, 339);
            Zapisz_button.Name = "Zapisz_button";
            Zapisz_button.Size = new Size(115, 50);
            Zapisz_button.TabIndex = 12;
            Zapisz_button.Text = "Zapisz";
            Zapisz_button.UseVisualStyleBackColor = true;
            Zapisz_button.Click += Zapisz_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MSI GeForce RTX 4080 SUPRIM X 16GB GDDR6X 256bit", "Inno3D GeForce RTX 4070 Ti X3 12GB GDDR6X 192bit", "GeForce RTX 3060 Ti EAGLE OC (rev. 2.0) 8GB GDDR6 256bit", "MSI GeForce RTX 3060 Ti VENTUS 2X OCV1 LHR 8GB GDDR6", "PowerColor Radeon RX 7900 XT 20GB GDDR6 320bit", "XFX Radeon RX 6700 CORE Gaming SWFT 309 10GB GDDR6 160bit", "ASUS GeForce GTX 1660 SUPER OC 6GB GDDR6" });
            comboBox1.Location = new Point(12, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(523, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(210, 274);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 14;
            label3.Text = "Karta graficzna :";
            // 
            // Komputer_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(Zapisz_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dysk_Label);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Komputer_form";
            Text = "Komputer_form";
            Load += Komputer_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label Dysk_Label;
        private Label label1;
        private Label label2;
        private Button Zapisz_button;
        private ComboBox comboBox1;
        private Label label3;
    }
}