using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAI_8Puzzle
{
    class squareCoords
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Number { get; set; }

        public squareCoords(int x, int y, int number)
        {
            this.X = x;
            this.Y = y;
            this.Number = number;
        }

    }
}
