using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_1_geometry
{
    public class CampareTwoLines
    {

        int X1;
        int X2;
        int Y1;
        int Y2;

        double Length_XY;

        public void CampareTwoLines()
        {

            double x1 = 4, x2 = 6, y1 = 7, y2 = 8;

            double a1 = 2, a2 = 3, b1 = 4, b2 = 5;

            double Compare Two Lines = ((y2 - y1) * a1 + (x1 - x2) * b1 + (x2 * Y1 - x1 * y2));

            Console.WriteLine(Compare Two Lines);

            double x3 = 2, x4 = 3, y3 = 4, y4 = 5;

            double a1 = 1, a2 = 3, b1 = 5, b2 = 7;

            double Compare Two Lines = ((y2 - y1) * a1 + (x1 - x2) * b1 + (x2 * Y1 - x1 * y2));

            Console.WriteLine(Compare Two Lines);
        }

    }
}
