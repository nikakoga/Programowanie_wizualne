namespace Edycja_picturebox
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
            pictureBox1 = new PictureBox();
            OnlyGreenButton = new Button();
            TurnButton = new Button();
            VerticalMirrorButton = new Button();
            HorizontalMirrorButton = new Button();
            NegativeButton = new Button();
            LoadPictureButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // OnlyGreenButton
            // 
            OnlyGreenButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OnlyGreenButton.Location = new Point(580, 12);
            OnlyGreenButton.Name = "OnlyGreenButton";
            OnlyGreenButton.Size = new Size(188, 29);
            OnlyGreenButton.TabIndex = 10;
            OnlyGreenButton.Text = "ONLY GREEN";
            OnlyGreenButton.UseVisualStyleBackColor = true;
            OnlyGreenButton.Click += OnlyGreenButton_Click;
            // 
            // TurnButton
            // 
            TurnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TurnButton.Location = new Point(580, 97);
            TurnButton.Name = "TurnButton";
            TurnButton.Size = new Size(188, 29);
            TurnButton.TabIndex = 11;
            TurnButton.Text = "TURN";
            TurnButton.UseVisualStyleBackColor = true;
            // 
            // VerticalMirrorButton
            // 
            VerticalMirrorButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VerticalMirrorButton.Location = new Point(580, 174);
            VerticalMirrorButton.Name = "VerticalMirrorButton";
            VerticalMirrorButton.Size = new Size(188, 29);
            VerticalMirrorButton.TabIndex = 12;
            VerticalMirrorButton.Text = "VERTICLE MIRROR";
            VerticalMirrorButton.UseVisualStyleBackColor = true;
            // 
            // HorizontalMirrorButton
            // 
            HorizontalMirrorButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HorizontalMirrorButton.Location = new Point(580, 260);
            HorizontalMirrorButton.Name = "HorizontalMirrorButton";
            HorizontalMirrorButton.Size = new Size(188, 29);
            HorizontalMirrorButton.TabIndex = 13;
            HorizontalMirrorButton.Text = "HORIZONTAL MIRROR";
            HorizontalMirrorButton.UseVisualStyleBackColor = true;
            // 
            // NegativeButton
            // 
            NegativeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NegativeButton.Location = new Point(580, 340);
            NegativeButton.Name = "NegativeButton";
            NegativeButton.Size = new Size(188, 29);
            NegativeButton.TabIndex = 14;
            NegativeButton.Text = "NEGATIVE";
            NegativeButton.UseVisualStyleBackColor = true;
            NegativeButton.Click += NegativeButton_Click;
            // 
            // LoadPictureButton
            // 
            LoadPictureButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadPictureButton.Location = new Point(207, 407);
            LoadPictureButton.Name = "LoadPictureButton";
            LoadPictureButton.Size = new Size(157, 29);
            LoadPictureButton.TabIndex = 15;
            LoadPictureButton.Text = "LOAD";
            LoadPictureButton.UseVisualStyleBackColor = true;
            LoadPictureButton.Click += LoadPictureButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(LoadPictureButton);
            Controls.Add(NegativeButton);
            Controls.Add(HorizontalMirrorButton);
            Controls.Add(VerticalMirrorButton);
            Controls.Add(TurnButton);
            Controls.Add(OnlyGreenButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button OnlyGreenButton;
        private Button TurnButton;
        private Button VerticalMirrorButton;
        private Button HorizontalMirrorButton;
        private Button NegativeButton;
        private Button LoadPictureButton;
    }
}