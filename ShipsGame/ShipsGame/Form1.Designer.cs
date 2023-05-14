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
            btnCheck = new Button();
            level = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbxSize = new TextBox();
            label2 = new Label();
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
            label5.Location = new Point(172, 123);
            label5.Name = "label5";
            label5.Size = new Size(269, 20);
            label5.TabIndex = 8;
            label5.Text = "Fill size with one number. Min 3 Max 20\r\n";
            // 
            // tbxSize
            // 
            tbxSize.Location = new Point(217, 161);
            tbxSize.Name = "tbxSize";
            tbxSize.Size = new Size(151, 27);
            tbxSize.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 161);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 10;
            label2.Text = "size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 349);
            Controls.Add(label2);
            Controls.Add(tbxSize);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(level);
            Controls.Add(btnCheck);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCheck;
        private ComboBox level;
        private Label label4;
        private Label label5;
        private TextBox tbxSize;
        private Label label2;
    }
}