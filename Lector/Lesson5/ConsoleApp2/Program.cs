using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate double Fun(double x);

    class Program
    {
        public static void TableForm(Fun F, double min, double max)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (min <= max)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", min, F(min));
                min += 1;
            }
            Console.WriteLine("---------------------");
        }

        static double Tan(double x)
        {
            return Math.Sin(x) / Math.Cos(x);
        }
        static void Main(string[] args)
        {
            TableForm(Tan, -5, 5);
        }
    }
}
