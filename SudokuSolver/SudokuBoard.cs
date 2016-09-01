using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class SudokuBoard
    {
        public static Graphics G;
        public void DrawBoard()
        {
            for(int i=0;i<10;i++)
            {
                G.DrawLine(new Pen(Color.Black), new Point(0, i * 45), new Point(9 * 45, i * 45));
                G.DrawLine(new Pen(Color.Black), new Point(i * 45, 0), new Point(i * 45, 9 * 45));
            }
        }
    }
}
