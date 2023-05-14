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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            tbxRows = new TextBox();
            tbxCols = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
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
            tbxRows.Location = new Point(217, 104);
            tbxRows.Name = "tbxRows";
            tbxRows.Size = new Size(125, 27);
            tbxRows.TabIndex = 1;
            // 
            // tbxCols
            // 
            tbxCols.Location = new Point(217, 137);
            tbxCols.Name = "tbxCols";
            tbxCols.Size = new Size(125, 27);
            tbxCols.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 137);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "columns";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 107);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "rows";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(242, 198);
            button1.Name = "button1";
            button1.Size = new Size(53, 44);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 287);
            Controls.Add(button1);
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
        private Button button1;
    }
}