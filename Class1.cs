using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle90
    {
        public static void Sq(double a, double b, double c)
        {
            double S;
            if ((a > 0) && (b > 0) && (c > 0))
            {
                if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("error");
                    Console.ReadLine();
                }
                else if ((a > b) && (a > c))
                {
                    S = b * c / 2;
                    Console.WriteLine("S=" + S);
                    Console.ReadLine();
                }
                else if ((b > a) && (b > c))
                {
                    S = a * c / 2;
                    Console.WriteLine("S=" + S);
                    Console.ReadLine();
                }
                else if ((c > a) && (c > b))
                {
                    S = b * a / 2;
                    Console.WriteLine("S="+S);
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("error");
                Console.ReadLine();
            }
            

        }
    }
}
