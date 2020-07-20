using kpblc2000;
using System;

namespace lesson01ex4_swap
{
    class Program
    {
        /// <summary>
        /// 
        /// Алексей Кулик kpblc2000@yandex.ru
        /// 
        /// Задача №4
        /// Написать программу обмена значениями двух переменных:
        /// а) с использованием третьей переменной;
        /// б) *без использования третьей переменной.
        /// </summary>
        static void Main()
        {

            int baseA = 10;
            int baseB = 20;

            int a = baseA;
            int b = baseB;

            Console.WriteLine("Начальные значения переменных : a = {0}, b= {1}", a, b);

            #region а) с применением временной переменной

            int temp = a;
            b = a;
            a = temp;
            Console.WriteLine("После применения временной переменной : a = {0}, b= {1}", a, b);

            #endregion

            #region б) без применения дополнительных переменных
            a = baseA;
            b = baseB;
            Console.WriteLine("Восстановлены начальные значения переменных : a = {0}, b= {1}", a, b);

            (a, b) = (b, a);
            Console.WriteLine("Без использования временной переменной : a = {0}, b= {1}", a, b);

            #endregion

            ConsoleExtensions.Pause();
        }
    }
}
