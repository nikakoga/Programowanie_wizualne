using ShipsGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        int columns;
        int rows;
        int gameLevel;

        double moves;
        double fieldsNum;
        double ships;
        Label[,] fields;

        public Game(int cols, int rws, int level)
        {
            InitializeComponent();
            columns = cols;
            rows = rws;
            gameLevel = level;

            fieldsNum = (columns * rows);
            ships = fieldsNum * 0.2;
            ships = (int)Math.Ceiling(ships);

            double modificator;
            Label[,] fields = new Label[cols, rws];

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
            FillBoard(columns, rows);
        }

        void FillBoard(int columns, int rows)
        {
            Image imgShip = Resources.ship;
            Image imgQuestion = Resources.questionmark;
            Image imgOcean = Resources.ocean;

            
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
