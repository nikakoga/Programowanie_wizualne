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
            components = new System.ComponentModel.Container();
            StopButton = new Button();
            Stoper = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StopButton.ForeColor = Color.LightCoral;
            StopButton.Location = new Point(100, 116);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(84, 49);
            StopButton.TabIndex = 0;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += button1_Click;
            // 
            // Stoper
            // 
            Stoper.AutoSize = true;
            Stoper.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stoper.ForeColor = Color.FloralWhite;
            Stoper.Location = new Point(90, 66);
            Stoper.Name = "Stoper";
            Stoper.Size = new Size(94, 28);
            Stoper.TabIndex = 1;
            Stoper.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(283, 219);
            Controls.Add(Stoper);
            Controls.Add(StopButton);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form2";
            Text = "Stopwatch";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StopButton;
        private Label Stoper;
        private System.Windows.Forms.Timer timer1;
    }
}