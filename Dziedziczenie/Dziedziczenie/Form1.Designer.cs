namespace Dziedziczenie
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
            FormOptions = new ComboBox();
            OpenForms = new Button();
            SuspendLayout();
            // 
            // FormOptions
            // 
            FormOptions.FormattingEnabled = true;
            FormOptions.Items.AddRange(new object[] { "Engineering thesis topic card", "Promoter's opinion", "Reviewer's opinion", "Examination board protocol form" });
            FormOptions.Location = new Point(172, 181);
            FormOptions.Name = "FormOptions";
            FormOptions.Size = new Size(431, 28);
            FormOptions.TabIndex = 1;
            // 
            // OpenForms
            // 
            OpenForms.Location = new Point(335, 236);
            OpenForms.Name = "OpenForms";
            OpenForms.Size = new Size(94, 29);
            OpenForms.TabIndex = 2;
            OpenForms.Text = "Open";
            OpenForms.UseVisualStyleBackColor = true;
            OpenForms.Click += OpenForms_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenForms);
            Controls.Add(FormOptions);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox FormOptions;
        private Button OpenForms;
    }
}