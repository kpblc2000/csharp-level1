using kpblc2000;
using System;

namespace lesson01ex5
{
    class Program
    {
        /// <summary>
        /// 
        /// Алексей Кулик kpblc2000@yandex.ru
        /// 
        /// Задача №5
        /// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        /// б) *Сделать задание, только вывод организовать в центре экрана.
        /// в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        /// </summary>
        static void Main()
        {

            string name = "Алексей Кулик";
            string town = "С.-Петербург";

            #region а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            ConsoleExtensions.Princ(name + " " + town);
            ConsoleExtensions.Pause();
            #endregion

            #region б) *Сделать задание, только вывод организовать в центре экрана.

            Console.Clear();
            int winWidth = Console.WindowWidth;
            int winHeight = Console.WindowHeight / 2 - 1;

            Console.SetCursorPosition((winWidth - name.Length) / 2, winHeight);
            Console.WriteLine(name);
            Console.SetCursorPosition((winWidth - town.Length) / 2, winHeight + 1);
            Console.WriteLine(town);
            Console.SetCursorPosition(winWidth / 2, winHeight + 4);
            ConsoleExtensions.Pause();

            #endregion

            #region в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            Console.Clear();
            winWidth = Console.WindowWidth;
            winHeight = Console.WindowHeight / 2 - 1;

            ConsoleExtensions.Princ(name, (winWidth - name.Length) / 2, winHeight, ConsoleColor.Green);
            ConsoleExtensions.Princ(town, (winWidth - town.Length) / 2, winHeight + 1);

            Console.SetCursorPosition(winWidth / 2, winHeight + 4);

            ConsoleExtensions.Pause();
            #endregion

        }
    }
}
