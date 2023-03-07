namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            clock.Location = new Point(82, 50);
            clock.Name = "clock";
            clock.Size = new Size(147, 34);
            clock.TabIndex = 0;
            clock.Text = "00:00:00 AM";
            clock.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(115, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 211);
            Controls.Add(button1);
            Controls.Add(clock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}