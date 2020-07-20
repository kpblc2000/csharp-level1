using System;


namespace kpblc2000
{
    /// <summary>
    /// 
    /// Алексей Кулик kpblc2000@yandex.ru
    /// 
    /// Задача №6*
    /// 
    /// Собственный класс с методами для работы с консолью
    /// 
    /// </summary>
    public static class ConsoleExtensions
    {

        public static void Princ()
        {
            Console.WriteLine();
        }

        public static void Princ(string Message)
        {
            Console.WriteLine(Message);
        }

        public static void Princ(string Message, ConsoleColor ForegroundColor)
        {
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(Message);
            Console.ResetColor();
            return;
        }

        public static void Princ(string Message, int CursorX, int CursorY)
        {
            Console.SetCursorPosition(CursorX, CursorY);
            Console.WriteLine(Message);
            return;
        }

        public static void Princ(string Message, int CursorX, int CursorY, ConsoleColor ForegroundColor)
        {
            Console.SetCursorPosition(CursorX, CursorY);
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(Message);
            Console.ResetColor();
            return;
        }

        public static void Pause()
        {            
            Console.Write("Нажмите любую клавишу...");
            Console.ReadKey();
            return;
        }

        public static void Pause(string Message)
        {
            Console.WriteLine(Message);
            Console.ReadKey();
            return;
        }

        public static void Pause(string Message, ConsoleColor ForegrounColor)
        {
            Console.ForegroundColor = ForegrounColor;
            Console.WriteLine(Message);
            Console.ResetColor();
            Console.ReadKey();
            return;
        }

        public static string GetValueFromConsole(string Message)
        {
            Console.Write(Message + " : ");
            return Console.ReadLine();
        }

        public static double GetValueFromConsoleAsDouble(string Message)
        {
            Console.Write(Message + " : ");
            return Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        }

    }

}