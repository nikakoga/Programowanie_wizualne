namespace MusicPlayer
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
            lbxPlaylist = new ListBox();
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnPause = new Button();
            BtnPlay = new Button();
            BtnStop = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // lbxPlaylist
            // 
            lbxPlaylist.BackColor = Color.FromArgb(31, 30, 68);
            lbxPlaylist.BorderStyle = BorderStyle.None;
            lbxPlaylist.ForeColor = Color.Red;
            lbxPlaylist.FormattingEnabled = true;
            lbxPlaylist.ItemHeight = 20;
            lbxPlaylist.Location = new Point(-1, 110);
            lbxPlaylist.Name = "lbxPlaylist";
            lbxPlaylist.Size = new Size(362, 340);
            lbxPlaylist.TabIndex = 0;
            lbxPlaylist.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.ForeColor = Color.Red;
            BtnAdd.Location = new Point(17, 61);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(53, 43);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDelete.ForeColor = Color.Red;
            BtnDelete.Location = new Point(85, 61);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(47, 43);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "-";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            BtnPause.ForeColor = SystemColors.ControlText;
            BtnPause.Image = Properties.Resources.iconPause;
            BtnPause.Location = new Point(516, 188);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(57, 40);
            BtnPause.TabIndex = 4;
            BtnPause.UseVisualStyleBackColor = true;
            BtnPause.Click += BtnPause_Click;
            // 
            // BtnPlay
            // 
            BtnPlay.Image = Properties.Resources.iconPlay;
            BtnPlay.Location = new Point(458, 188);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(52, 40);
            BtnPlay.TabIndex = 3;
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // BtnStop
            // 
            BtnStop.Image = Properties.Resources.iconStop;
            BtnStop.Location = new Point(579, 188);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(55, 40);
            BtnStop.TabIndex = 5;
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(406, 126);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(294, 56);
            trackBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 7;
            label1.Text = "Playlist";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(BtnStop);
            Controls.Add(BtnPause);
            Controls.Add(BtnPlay);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(lbxPlaylist);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxPlaylist;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnPause;
        private Button BtnPlay;
        private Button BtnStop;
        private TrackBar trackBar1;
        private Label label1;
    }
}