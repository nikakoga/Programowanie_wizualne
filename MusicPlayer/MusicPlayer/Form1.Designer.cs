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
            components = new System.ComponentModel.Container();
            lbxPlaylist = new ListBox();
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnPause = new Button();
            BtnPlay = new Button();
            BtnStop = new Button();
            label1 = new Label();
            pBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            TrbVolume = new TrackBar();
            BtnMute = new Button();
            LblTrackStart = new Label();
            LblTrackEnd = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            LblVolume = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrbVolume).BeginInit();
            SuspendLayout();
            // 
            // lbxPlaylist
            // 
            lbxPlaylist.BackColor = Color.FromArgb(31, 30, 68);
            lbxPlaylist.BorderStyle = BorderStyle.None;
            lbxPlaylist.ForeColor = Color.Red;
            lbxPlaylist.FormattingEnabled = true;
            lbxPlaylist.ItemHeight = 20;
            lbxPlaylist.Location = new Point(12, 244);
            lbxPlaylist.Name = "lbxPlaylist";
            lbxPlaylist.Size = new Size(489, 300);
            lbxPlaylist.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.ForeColor = Color.Red;
            BtnAdd.Location = new Point(144, 195);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(36, 36);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDelete.ForeColor = Color.Red;
            BtnDelete.Location = new Point(186, 195);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(36, 36);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "-";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnPause
            // 
            BtnPause.ForeColor = SystemColors.ControlText;
            BtnPause.Image = Properties.Resources.iconPause;
            BtnPause.Location = new Point(428, 109);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(57, 40);
            BtnPause.TabIndex = 4;
            BtnPause.UseVisualStyleBackColor = true;
            BtnPause.Click += BtnPause_Click;
            // 
            // BtnPlay
            // 
            BtnPlay.Image = Properties.Resources.iconPlay;
            BtnPlay.Location = new Point(370, 109);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(52, 40);
            BtnPlay.TabIndex = 3;
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // BtnStop
            // 
            BtnStop.Image = Properties.Resources.iconStop;
            BtnStop.Location = new Point(491, 109);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(55, 40);
            BtnStop.TabIndex = 5;
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(22, 202);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 7;
            label1.Text = "Playlist";
            // 
            // pBar
            // 
            pBar.Location = new Point(58, 64);
            pBar.Name = "pBar";
            pBar.Size = new Size(796, 29);
            pBar.TabIndex = 8;
            pBar.MouseDown += pBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconMusic1;
            pictureBox1.Location = new Point(608, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 263);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // TrbVolume
            // 
            TrbVolume.Location = new Point(546, 257);
            TrbVolume.Maximum = 100;
            TrbVolume.Name = "TrbVolume";
            TrbVolume.Orientation = Orientation.Vertical;
            TrbVolume.Size = new Size(56, 217);
            TrbVolume.TabIndex = 10;
            TrbVolume.TickStyle = TickStyle.TopLeft;
            TrbVolume.Scroll += TrbVolume_Scroll;
            // 
            // BtnMute
            // 
            BtnMute.Image = Properties.Resources.iconMute;
            BtnMute.Location = new Point(546, 480);
            BtnMute.Name = "BtnMute";
            BtnMute.Size = new Size(52, 40);
            BtnMute.TabIndex = 11;
            BtnMute.UseVisualStyleBackColor = true;
            BtnMute.Click += BtnMute_Click;
            // 
            // LblTrackStart
            // 
            LblTrackStart.AutoSize = true;
            LblTrackStart.FlatStyle = FlatStyle.Flat;
            LblTrackStart.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblTrackStart.ForeColor = Color.Red;
            LblTrackStart.Location = new Point(56, 27);
            LblTrackStart.Name = "LblTrackStart";
            LblTrackStart.Size = new Size(77, 29);
            LblTrackStart.TabIndex = 12;
            LblTrackStart.Text = "00:00";
            // 
            // LblTrackEnd
            // 
            LblTrackEnd.AutoSize = true;
            LblTrackEnd.FlatStyle = FlatStyle.Flat;
            LblTrackEnd.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblTrackEnd.ForeColor = Color.Red;
            LblTrackEnd.Location = new Point(777, 27);
            LblTrackEnd.Name = "LblTrackEnd";
            LblTrackEnd.Size = new Size(77, 29);
            LblTrackEnd.TabIndex = 13;
            LblTrackEnd.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LblVolume
            // 
            LblVolume.AutoSize = true;
            LblVolume.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblVolume.ForeColor = Color.Red;
            LblVolume.Location = new Point(546, 234);
            LblVolume.Name = "LblVolume";
            LblVolume.Size = new Size(37, 18);
            LblVolume.TabIndex = 16;
            LblVolume.Text = "50%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(904, 556);
            Controls.Add(LblVolume);
            Controls.Add(LblTrackEnd);
            Controls.Add(LblTrackStart);
            Controls.Add(BtnMute);
            Controls.Add(TrbVolume);
            Controls.Add(pictureBox1);
            Controls.Add(pBar);
            Controls.Add(label1);
            Controls.Add(BtnStop);
            Controls.Add(BtnPause);
            Controls.Add(BtnPlay);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(lbxPlaylist);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrbVolume).EndInit();
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
        private Label label1;
        private ProgressBar pBar;
        private PictureBox pictureBox1;
        private TrackBar TrbVolume;
        private Button BtnMute;
        private Label LblTrackStart;
        private Label LblTrackEnd;
        private System.Windows.Forms.Timer timer1;
        private Label LblVolume;
    }
}