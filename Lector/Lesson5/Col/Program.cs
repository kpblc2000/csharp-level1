using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Numerics;

//using System.Linq;

namespace Ex411
{
    class Programs
    {
        static void T()
        {

            #region Проблемы массивов. Добавление

            Console.WriteLine("--- Проблемы массивов. Добавление ---");
            var arr = new int[] { 4, 8, 15, 16, 23, 42 }; // 1 000 000
            PrintArr(arr, "Исходный Arr:");
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = 2025;
            PrintArr(arr, "Полученный Arr:");

            #endregion

            #region Проблемы массивов. Удаление

            Console.WriteLine("--- Проблемы массивов. Удаление ---");
            var Brr = new int[] { 4, 2, 19, 2017, 16, 23, 42 };
            PrintArr(Brr, "Исходный Brr:");
            //Console.Write("Введите индекс удаляемого элемента: ");
            int index = 3;
            //Convert.ToInt32(Console.ReadLine()) - 1;

            if (DeleteElement(ref Brr, index))
            { PrintArr(Brr, "Полученный Brr:"); }
            else
            { Console.WriteLine("Неверный индекс элемента"); }

            #endregion

            #region Новый функционал массивов

            Console.WriteLine("--- Новый функционал массивов ---");
            var Crr = Array.CreateInstance(typeof(int), 10);
            // new int[10];

            for (int i = 0; i < Crr.Length; i++)
            {
                Crr.SetValue(Crr.Length - i, i);  // Добавление элемента
            }

            //int elCrr = (int)Crr.GetValue(3);   // Получение элемента

            Console.WriteLine("Исходный Сrr:");

            foreach (var item in Crr)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("\n");

            #endregion

            #region ArrayList

            Console.WriteLine("--- ArrayList ---");

            ArrayList arrList = new ArrayList(); // нужно using System.Collections;

            //arrList.Add()
            arrList.Add(1990);      // Добавление элемента в конец коллекции
            arrList.Add(1991);      // Добавление элемента в конец коллекции
            arrList.Add(1992);      // Добавление элемента в конец коллекции
            arrList.Add(1993);      // Добавление элемента в конец коллекции
            arrList.Add(1994);      // Добавление элемента в конец коллекции
            arrList.Add("огого");   // Добавление элемента в конец коллекции

            arrList.Add(arrList);   // Добавление элемента в конец коллекции
            arrList.CopyTo(arr);    // Копирование коллекции в массив
            // arrList.Sort();      // 
            arrList.Reverse();      //
            arrList.AddRange(new int[] { 34, 5, 2014, 5, 5, 5, 4 });
            arrList.AddRange(new object[] { "Лето", "Зима" });
            arrList.Insert(1, "!!!");       // Добавление элемена в коллекцию на заданную позицию
            arrList.Remove(5);              // находит первое хождение указанного элемента в коллекцию и удаляет его
            arrList.RemoveAt(1);            // Удаляет элемент на указанной позиции

            arrList[0] = 132;

            foreach (var item in arrList)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine("\n Всего элементов в arrList {0}", arrList.Count);
            Console.WriteLine("\n Это поиск {0} \n", arrList.IndexOf(2014));
            //arrList.Clear();



            #endregion

            #region List<T>

            Console.WriteLine("--- List<T> ---");
            // Add
            // Remove
            // Contains
            // IndexOf
            // LastIndexOf
            // []
            // RemoveAt
            // Insert
            // Count
            // Clear
            //Сортировка списка
            // Sort или Sort(функция_сравнения)
            // Reverse

            List<int> parametricArrList = new List<int>() { 1, 2, 3, 4, 5, 5, 5, 1, 1, 2, 2, 3, 6 };

            parametricArrList.Add(123);

            parametricArrList[1] = 11;
            //List<List<int>> f = new List<List<int>>();

            for (int i = 0; i < 10; i++)
            {
                parametricArrList.Add(i);
            }

            for (int i = 0; i < parametricArrList.Count; i++)
            {
                Console.Write("{0} ", parametricArrList[i]);
            }
           
            parametricArrList.Sort();
            Console.WriteLine("\n");
            Console.WriteLine(parametricArrList.BinarySearch(2));

            #endregion

            #region Dictionary

            Console.WriteLine("--- Dictionary ---");

            Dictionary<string, string> dicArr = new Dictionary<string, string>();
            //         ключ ,  значение
            // Count
            // Clear
            // []
            // ContainsKey
            // Remove
            // Keys
            // Values
            // KeyValuePair<string, string>

            dicArr.Add("left", "влево");
            dicArr.Add("top", "вверх");
            dicArr.Add("down", "вниз");
            dicArr.Add("right", "вправо");

            string tempStr = dicArr["down"];        // получение списка по ключу

            foreach (var item in dicArr.Keys)       // Вывод всех ключей
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n");

            foreach (var item in dicArr.Values)       // Вывод всех Значений
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n");

            dicArr.Remove("left");  // Удаление по ключу

            foreach (var item in dicArr)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Элементов в словаре: {0}", dicArr.Count);
            dicArr.Clear();             // Очистить словарь



            #endregion


            #region Stack

            Console.WriteLine("--- Stack ---");
            // Push
            // Pop
            // Peek
            // Count
            // Clear


            Stack<int> staskArr = new Stack<int>();
            // First In Last Out - FILO

            //staskArr.Push - Добавить элемент в стек
            //staskArr.Pop - извлечь элемент из стека
            //staskArr.Peek - показать последний элемент стека
            //staskArr.Count - количество элементов в стеке
            //staskArr.Clear - очистить стек


            staskArr.Push(2022);
            staskArr.Push(9);
            staskArr.Push(28);
            staskArr.Push(1900);

            Console.WriteLine(staskArr.Pop());
            //Console.ReadLine();
            Console.WriteLine(staskArr.Pop());
            //Console.ReadLine();
            Console.WriteLine(staskArr.Pop());
            //Console.ReadLine();
            Console.WriteLine(staskArr.Peek());
            //Console.ReadLine();
            Console.WriteLine(staskArr.Pop());
            //Console.ReadLine();

            #endregion



            Console.ReadLine();
        }

        private static void PrintArr(int[] Arr, string Label = "")
        {
            Console.WriteLine(Label);
            foreach (var item in Arr)
            { Console.Write("{0} ", item); }
            Console.WriteLine("\n");
        }
        private static void PrintArr(double[] Arr, string Label = "")
        {
            Console.WriteLine(Label);
            foreach (var item in Arr)
            { Console.Write("{0} ", item); }
            Console.WriteLine("\n");
        }
        private static bool DeleteElement(ref int[] Arr, int Index)
        {
            bool result = false;

            if (Index >= 0 && Index <= Arr.Length)
            {
                for (int i = Index; i < Arr.Length - 1; i++)
                { Arr[i] = Arr[i + 1]; }
                Array.Resize(ref Arr, Arr.Length - 1);
                result = true;
            }
            else
            { result = false; }
            return result;
        }






    }
}