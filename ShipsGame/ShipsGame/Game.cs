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
        double fields;
        double ships;
        double modificator;
       
        public Game(int cols, int rws, int level)
        {
            InitializeComponent();
            columns = cols;
            rows = rws;
            gameLevel = level;

            fields= (columns*rows);
            ships = fields * 0.2;
            ships = (int)Math.Ceiling(ships);

            switch (gameLevel)
            {
                    case 0:
                    {
                        modificator = 0.8;
                        break;
                    }
                    case 1:
                    {
                        modificator = 0.5;
                        break;

                    }
                    case 2:
                    {
                        modificator = 0.35;
                        break;
                    }
                         
            }
            moves = (int)Math.Floor(fields * modificator);

            MessageBox.Show($"Ruchow {moves} statkow {ships}");
        }
    }
}
