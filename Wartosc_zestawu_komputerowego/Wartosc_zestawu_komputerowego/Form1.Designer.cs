namespace Wartosc_zestawu_komputerowego
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
            suma_wartosci = new Label();
            Komputer_Button = new Button();
            MonitorButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // suma_wartosci
            // 
            suma_wartosci.AutoSize = true;
            suma_wartosci.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            suma_wartosci.ForeColor = Color.Black;
            suma_wartosci.Location = new Point(315, 292);
            suma_wartosci.Name = "suma_wartosci";
            suma_wartosci.Size = new Size(143, 38);
            suma_wartosci.TabIndex = 0;
            suma_wartosci.Text = "0000,00zł";
            suma_wartosci.Click += suma_wartosci_Click;
            // 
            // Komputer_Button
            // 
            Komputer_Button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Komputer_Button.Location = new Point(189, 129);
            Komputer_Button.Name = "Komputer_Button";
            Komputer_Button.Size = new Size(154, 62);
            Komputer_Button.TabIndex = 1;
            Komputer_Button.Text = "Komputer";
            Komputer_Button.UseVisualStyleBackColor = true;
            Komputer_Button.Click += Komputer_Button_Click;
            // 
            // MonitorButton
            // 
            MonitorButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MonitorButton.Location = new Point(396, 129);
            MonitorButton.Name = "MonitorButton";
            MonitorButton.Size = new Size(146, 62);
            MonitorButton.TabIndex = 2;
            MonitorButton.Text = "Monitor";
            MonitorButton.UseVisualStyleBackColor = true;
            MonitorButton.Click += MonitorButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(324, 255);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 3;
            label1.Text = "Cena :";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(MonitorButton);
            Controls.Add(Komputer_Button);
            Controls.Add(suma_wartosci);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label suma_wartosci;
        private Button Komputer_Button;
        private Button MonitorButton;
        private Label label1;
    }
}