using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kpblc2000;

namespace lesson01ex2_bmi
{
    class Program
    {
        /// <summary>
        /// 
        /// Алексей Кулик kpblc2000@yandex.ru
        /// 
        /// Задача №2
        /// 
        /// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
        /// </summary>
        static void Main()
        {
            double weight = Convert.ToDouble(ConsoleExtensions.GetValueFromConsole("Введите вес, кг : ").Replace('.', ','));
            double tall = Convert.ToDouble(ConsoleExtensions.GetValueFromConsole("Введите рост, м : ").Replace('.',','));
            ConsoleExtensions.Princ("Idx = mass / h^2 при росте " + tall + " м и весе в " + weight + " кг равен " + (weight / Math.Pow(tall, 2)).ToString("N4"), ConsoleColor.Green);
            ConsoleExtensions.Pause();
        }
    }
}
