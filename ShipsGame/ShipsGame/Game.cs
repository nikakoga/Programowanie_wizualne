using ShipsGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipsGame
{
    public partial class Game : Form
    {
        int size;
        int gameLevel;

        double moves;
        double fieldsNum;
        double ships;
        Label[,] fields;

        public Game(int sqr, int level)
        {
            InitializeComponent();
            size = sqr;
            gameLevel = level;

            fieldsNum = (size*size);
            ships = fieldsNum * 0.2;
            ships = (int)Math.Ceiling(ships);

            double modificator;
            //Label[,] fields = new Label[cols, rws];

            switch (gameLevel)
            {
                case 0:
                    {
                        modificator = 0.8;
                        moves = (int)Math.Floor(fieldsNum * modificator);
                        break;
                    }
                case 1:
                    {
                        modificator = 0.5;
                        moves = (int)Math.Floor(fieldsNum * modificator);
                        break;

                    }
                case 2:
                    {
                        modificator = 0.35;
                        moves = (int)Math.Floor(fieldsNum * modificator);
                        break;
                    }
                case 3:
                    {
                        moves = ships;
                        break;
                    }
            }
            //MessageBox.Show($"Ruchow {moves} statkow {ships}");
            FillBoard(size);
        }

        void FillBoard(int size)
        {
            Image imgShip = Resources.ship;
            Image imgQuestion = Resources.questionmark;
            Image imgOcean = Resources.ocean;

            TableLayoutPanel gamePanel = new TableLayoutPanel();
            gamePanel.RowCount = size;
            gamePanel.ColumnCount = size;
            //gamePanel.Anchor = AnchorStyles.None;
            //gamePanel.Dock = DockStyle.Fill;

            gamePanel.Anchor = AnchorStyles.None;
            gamePanel.Dock = DockStyle.None;
            gamePanel.Size = new Size(size * 40, size * 40);
            gamePanel.Location = new Point((this.ClientSize.Width - gamePanel.Width) / 2, (this.ClientSize.Height - gamePanel.Height) / 2);


            for (int row = 0; row < gamePanel.RowCount; row++)
            {
                for (int col = 0; col < gamePanel.ColumnCount; col++)
                {
                    Label label = new Label();
                    label.Image = imgQuestion;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Margin = new Padding(0);
                    label.Size = new Size(40, 40);
                    gamePanel.Controls.Add(label, col, row);

                    // Przypisujemy akcję po kliknięciu
                    label.Click += new EventHandler(label_Click);

                    gamePanel.Controls.Add(label, col, row);
                }
            }

            this.Controls.Add(gamePanel);
            this.ShowDialog();
        }

        private int Draw(double ships, double fieldsNum)
        {

            return 0;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
        }
    }

//    int x = 40, y = 40;

//            for (int col = 0; col<columns; col++)
//            {
//                for (int row = 0; row<rows; row++)
//                {

//                    fields[col, row].Location = new Point(x, y);
//    fields[col, row].BackColor = Color.White;
//                    fields[col, row].Image = imgQuestion;
//                    fields[col, row].Text = string.Empty;
//                    fields[col, row].Click += label_Click;
//                    fields[col, row].Size = new Size(40, 40);
//    Controls.Add(fields[col, row]);
//                    x += 40;
//                }
//y += 40;
//x = 40;
            
}
