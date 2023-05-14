using ShipsGame.Properties;
using System;
using System.Collections;
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

        double shipsLeft;
        double oceanLeft;

        Image imgOcean = Resources.ocean;
        Image imgShip = Resources.ship;
        Image imgQuestion = Resources.questionmark;

        public Game(int sqr, int level)
        {
            InitializeComponent();
            size = sqr;
            gameLevel = level;

            fieldsNum = (size*size);
            ships = fieldsNum * 0.2;
            ships = (int)Math.Ceiling(ships);

            shipsLeft = ships;
            oceanLeft = fieldsNum - ships;

            double modificator;
           
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
            TableLayoutPanel gamePanel = new TableLayoutPanel();
            gamePanel.RowCount = size;
            gamePanel.ColumnCount = size;
          

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

                    
                    label.Click += new EventHandler(label_Click);

                    gamePanel.Controls.Add(label, col, row);
                }
            }

            this.Controls.Add(gamePanel);
            int margin = 50; 
            ClientSize = new Size(gamePanel.Width + margin * 2, gamePanel.Height + margin * 3);
            this.CenterToScreen();
            this.ShowDialog();
        }

        private bool Draw()
        {
            bool [] arrOcean = new bool[Convert.ToInt32(oceanLeft)];
            bool [] arrShips = new bool [Convert.ToInt32(shipsLeft)];

            for (int i = 0; i < arrOcean.Length; i++)
            {
                arrOcean[i] = false;
            }
            for (int j = 0; j < arrShips.Length; j++)
            {
                arrShips[j] = true;
            }

            bool [] result = new bool [arrOcean.Length + arrShips.Length];
            arrOcean.CopyTo(result, 0);
            arrShips.CopyTo(result, arrOcean.Length);

            Random random = new Random();
            int randomNumber = random.Next(0, result.Length-1);
            
            bool sink=result[randomNumber];

            if(sink)
            {
                shipsLeft -= 1;
            }
            else
            {
                oceanLeft -= 1;
            }

            return sink;
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            if (Draw())
            {
                tmp.Image = imgShip;
            }
            else
            {
                tmp.Image = imgOcean;
            }
        }
    }


            
}
