using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv();
            Udskriv("Dette er en test");
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);
            double res4 = BeregnMoms(100.35, 20);
            Console.WriteLine(res4);
            int[] løn = {10000, 5000, 30000};
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);

            Console.ReadKey();
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(double radius)
        {
            return (radius * radius) * Math.PI;
        }

        static double Gennemsnit(int[] lønninger)
        {
            int total = 0;
            for (int i = 0; i < lønninger.Length; i++)
            {
                total += lønninger[i];
            }
            return total / lønninger.Length;
        }

        static void Udskriv()
        {
            Console.WriteLine();
        }
        static void Udskriv(string linje)
        {
            Console.WriteLine(linje);
        }

        static double BeregnMoms(double beløb, double moms = 25)
        {
            return (beløb * moms) / 100;
        }
    }
}
