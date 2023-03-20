namespace ZapisOdczyt
{
    partial class FormMAIN
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
            buttonADD = new Button();
            buttonLOAD = new Button();
            buttonDELETE = new Button();
            buttonSAVE = new Button();
            SuspendLayout();
            // 
            // buttonADD
            // 
            buttonADD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonADD.Location = new Point(107, 66);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(94, 29);
            buttonADD.TabIndex = 0;
            buttonADD.Text = "ADD";
            buttonADD.UseVisualStyleBackColor = true;
            buttonADD.Click += buttonADD_Click;
            // 
            // buttonLOAD
            // 
            buttonLOAD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLOAD.Location = new Point(107, 304);
            buttonLOAD.Name = "buttonLOAD";
            buttonLOAD.Size = new Size(94, 29);
            buttonLOAD.TabIndex = 1;
            buttonLOAD.Text = "LOAD";
            buttonLOAD.UseVisualStyleBackColor = true;
            // 
            // buttonDELETE
            // 
            buttonDELETE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDELETE.Location = new Point(107, 135);
            buttonDELETE.Name = "buttonDELETE";
            buttonDELETE.Size = new Size(94, 29);
            buttonDELETE.TabIndex = 2;
            buttonDELETE.Text = "DELETE";
            buttonDELETE.UseVisualStyleBackColor = true;
            // 
            // buttonSAVE
            // 
            buttonSAVE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSAVE.Location = new Point(107, 216);
            buttonSAVE.Name = "buttonSAVE";
            buttonSAVE.Size = new Size(94, 29);
            buttonSAVE.TabIndex = 3;
            buttonSAVE.Text = "SAVE";
            buttonSAVE.UseVisualStyleBackColor = true;
            // 
            // FormMAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSAVE);
            Controls.Add(buttonDELETE);
            Controls.Add(buttonLOAD);
            Controls.Add(buttonADD);
            Name = "FormMAIN";
            Text = "FormMAIN";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonADD;
        private Button buttonLOAD;
        private Button buttonDELETE;
        private Button buttonSAVE;
    }
}