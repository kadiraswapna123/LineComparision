using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_1_geometry
{
    public class CampareTwoLines
    {

        int x1;
        int x2;
        int y1;
        int y2;

        double Length_xy;

        public void CalculateLength()

        {
            Console.WriteLine("Enter x,y Co_Ordinates of the Point 1: ");

            Console.WriteLine("Enter Value x1: ");

            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value y1: ");

            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x,y Co_Ordinates of the Point 2: ");

            Console.WriteLine("Enter Value x2: ");

            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x,y Co_Ordinates of the Point 3: ");

            Console.WriteLine("Enter Value y2: ");

            y2 = Convert.ToInt32(Console.ReadLine());

            Length_xy = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Value is : " + Length_xy);
            Console.WriteLine("===================================================================================");
        }
    }
}

        }
      
    }
}

