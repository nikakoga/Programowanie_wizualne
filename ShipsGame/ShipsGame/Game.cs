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
        public Game(int cols, int rws)
        {
            InitializeComponent();
            columns = cols;
            rows = rws;
        }
    }
}
