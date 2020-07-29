using kpblc2000;
using System;

namespace Lesson01Task3
{
    class Program
    {

        /// <summary>
        /// 
        /// Алексей Кулик kpblc2000@yandex.ru
        /// 
        /// Задача №2
        /// 
        /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        /// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        /// </summary>
        static void Main()
        {
            double x1 = ConsoleExtensions.GetValueFromConsoleAsDouble("x1=");
            double y1 = ConsoleExtensions.GetValueFromConsoleAsDouble("y1=");
            double x2 = ConsoleExtensions.GetValueFromConsoleAsDouble("x2=");
            double y2 = ConsoleExtensions.GetValueFromConsoleAsDouble("y2=");

            string distCoords;
            // вариант а)
            distCoords = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))).ToString("N4");
            ConsoleExtensions.Princ("Dist by coords = " + distCoords, ConsoleColor.Green);

            // вариант б)
            distCoords = EvalDistance(x1, y1, x2, y2).ToString("N4");
            ConsoleExtensions.Princ("Dist by method = " + distCoords, ConsoleColor.Red);
            ConsoleExtensions.Pause();
        }

        private static double EvalDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

    }
}
