namespace WinFormsApp1
{
    partial class Form2
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
            StopButton = new Button();
            Stoper = new Label();
            SuspendLayout();
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StopButton.Location = new Point(123, 118);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(96, 52);
            StopButton.TabIndex = 0;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += button1_Click;
            // 
            // Stoper
            // 
            Stoper.AutoSize = true;
            Stoper.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stoper.Location = new Point(123, 71);
            Stoper.Name = "Stoper";
            Stoper.Size = new Size(96, 31);
            Stoper.TabIndex = 1;
            Stoper.Text = "00:00:00";
            Stoper.Click += Stoper_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 231);
            Controls.Add(Stoper);
            Controls.Add(StopButton);
            Name = "Form2";
            Text = "Stopwatch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StopButton;
        private Label Stoper;
    }
}