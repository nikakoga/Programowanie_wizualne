namespace ZapisOdczyt
{
    partial class FormSAVE
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
            textBoxFOLDER = new TextBox();
            textBoxPLIK = new TextBox();
            labelFOLDER = new Label();
            labelPLIK = new Label();
            buttonSAVE_2 = new Button();
            SuspendLayout();
            // 
            // textBoxFOLDER
            // 
            textBoxFOLDER.Location = new Point(12, 76);
            textBoxFOLDER.Name = "textBoxFOLDER";
            textBoxFOLDER.Size = new Size(545, 27);
            textBoxFOLDER.TabIndex = 0;
            textBoxFOLDER.TextChanged += textBoxFOLDER_TextChanged;
            // 
            // textBoxPLIK
            // 
            textBoxPLIK.Location = new Point(123, 187);
            textBoxPLIK.Name = "textBoxPLIK";
            textBoxPLIK.Size = new Size(322, 27);
            textBoxPLIK.TabIndex = 1;
            // 
            // labelFOLDER
            // 
            labelFOLDER.AutoSize = true;
            labelFOLDER.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelFOLDER.Location = new Point(180, 30);
            labelFOLDER.Name = "labelFOLDER";
            labelFOLDER.Size = new Size(254, 23);
            labelFOLDER.TabIndex = 2;
            labelFOLDER.Text = "Podaj ścieżkę  folderu do zapisu";
            labelFOLDER.Click += label1_Click;
            // 
            // labelPLIK
            // 
            labelPLIK.AutoSize = true;
            labelPLIK.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelPLIK.Location = new Point(224, 151);
            labelPLIK.Name = "labelPLIK";
            labelPLIK.Size = new Size(148, 23);
            labelPLIK.TabIndex = 3;
            labelPLIK.Text = "Podaj nazwe pliku";
            // 
            // buttonSAVE_2
            // 
            buttonSAVE_2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSAVE_2.Location = new Point(234, 265);
            buttonSAVE_2.Name = "buttonSAVE_2";
            buttonSAVE_2.Size = new Size(94, 29);
            buttonSAVE_2.TabIndex = 4;
            buttonSAVE_2.Text = "SAVE";
            buttonSAVE_2.UseVisualStyleBackColor = true;
            buttonSAVE_2.Click += buttonSAVE_2_Click;
            // 
            // FormSAVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 346);
            Controls.Add(buttonSAVE_2);
            Controls.Add(labelPLIK);
            Controls.Add(labelFOLDER);
            Controls.Add(textBoxPLIK);
            Controls.Add(textBoxFOLDER);
            Name = "FormSAVE";
            Text = "FormSAVE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxFOLDER;
        public TextBox textBoxPLIK;
        private Label labelFOLDER;
        private Label labelPLIK;
        private Button buttonSAVE_2;
    }
}