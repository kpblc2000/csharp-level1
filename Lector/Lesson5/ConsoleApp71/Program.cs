using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{

    delegate void Del();

    delegate void Prorab();
    class Program
    {
        //static void A()
        //{
        //    Console.WriteLine("Привет"); 
        //}


        static void Main(string[] args)
        {
            //Del d = new Del(A);

            //d();

            Prorab ali = Builder1;
            ali();

            ali = Builder2;
            ali();

            ali = Builder3;
            ali();

        }

        private static void Builder3()
        {
            Console.WriteLine("Сделать крышу");
        }

        private static void Builder2()
        {
            Console.WriteLine("Возвести стены");
        }

        private static void Builder1()
        {
            Console.WriteLine("Залить фундамент");
        }
    }
}
