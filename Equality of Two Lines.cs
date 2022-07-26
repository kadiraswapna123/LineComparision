using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc_1_geometry
{
    internal class Equality_of_Two_Lines
    {
        int x1;
        int y1;
        int x2;
        int y2;
        int A1;
        int B1;
        int A2;
        int B2;

        double Length_XY;

        double Length_AB;

        public void CalulateLength()
        {

            Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            
            Console.Write("Enter Value X1: ");
            
            x1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Value Y1: ");
           
            y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter X,Y Co_Ordinates of the point 2: ");
           
            
            Console.Write("Enter Value X2: ");
            
            x2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Value Y2: ");
            
            y2 = Convert.ToInt32(Console.ReadLine());
           
            Length_XY = Math.Sqrt(Math.Pow((x2 - X1), 2) + Math.Pow((y2 - Y1), 2));
            
            Console.WriteLine("Length of Value is : " + Length_XY);
           
            Console.WriteLine("================================================================================================================");
        }
    }
}

    }
}
