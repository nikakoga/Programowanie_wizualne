namespace Wartosc_zestawu_komputerowego
{
    partial class Monitor_form
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
            ListViewItem listViewItem1 = new ListViewItem("HP Biedak 15''");
            ListViewItem listViewItem2 = new ListViewItem("Acer Predator 25''");
            ListViewItem listViewItem3 = new ListViewItem("Asus TUF 23''");
            ListViewItem listViewItem4 = new ListViewItem("Samsung Oddysey 20''");
            listView1 = new ListView();
            Zapisz_button = new Button();
            label_cena = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.Navy;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(288, 91);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(216, 139);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Zapisz_button
            // 
            Zapisz_button.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Zapisz_button.ForeColor = Color.Navy;
            Zapisz_button.Location = new Point(413, 279);
            Zapisz_button.Name = "Zapisz_button";
            Zapisz_button.Size = new Size(115, 50);
            Zapisz_button.TabIndex = 13;
            Zapisz_button.Text = "Zapisz";
            Zapisz_button.UseVisualStyleBackColor = true;
            Zapisz_button.Click += Zapisz_button_Click;
            // 
            // label_cena
            // 
            label_cena.AutoSize = true;
            label_cena.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_cena.ForeColor = Color.Navy;
            label_cena.Location = new Point(259, 298);
            label_cena.Name = "label_cena";
            label_cena.Size = new Size(98, 31);
            label_cena.TabIndex = 14;
            label_cena.Text = "0000,00";
            label_cena.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(272, 273);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 15;
            label2.Text = "Cena :";
            label2.Click += label2_Click;
            // 
            // Monitor_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label_cena);
            Controls.Add(Zapisz_button);
            Controls.Add(listView1);
            Name = "Monitor_form";
            Text = "Monitor_form";
            Load += Monitor_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button Zapisz_button;
        private Label label_cena;
        private Label label2;
    }
}