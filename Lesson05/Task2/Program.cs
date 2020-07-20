using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 5, задача 2
	/// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
	/// а) Вывести только те слова сообщения,  которые содержат не более n букв.
	/// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
	/// в) Найти самое длинное слово сообщения.
	/// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
	/// д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary
	/// </summary>
	class Program
	{
		static void Main()
		{

			string msg = "Проверка работы обработки. Строка не запрашивается, она предопределена.";

			int lim = 8;

			Console.WriteLine($"Нахождение слов короче {lim} символов");
			string[] shortRes = Message.GetWordsShorter(msg, 8);

#if DEBUG
			Console.WriteLine("Длины имеющихся слов : ");
			foreach (string item in msg.Split(new char[] { ' ' }))
			{
				Console.WriteLine("{0} -> {1}", item, item.Length);
			}
#endif

			foreach (string item in shortRes)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine($"Без оканчивающихся на 'и' : {Message.EraseWordsEndedWith(msg, 'и')}");
			Console.WriteLine($"Самое длинное слово : {Message.GetLongestWord(msg)}");
			lim = 6;
			Console.WriteLine($"Слова длиннее {lim} символов : {Message.LongerWords(msg, lim)}");
			Console.WriteLine($"Самые длинные слова : {Message.LongerWords(msg)}");
			Console.WriteLine("Частотный анализ текста");

			msg = "мама мыла раму мама любит машу маша любит кашу";
			string[] freqData = new string[] { "мама", "любит", "маша" };

			Dictionary<string, int> dict = Message.FreqAnalytics(msg, freqData);
			Console.WriteLine($"Проверяемая строка : {msg}");
			Console.WriteLine("Массив для анализа :");
			for (int i = 0; i < freqData.Length; i++)
			{
				Console.Write(freqData[i] + " ");
			}
			Console.WriteLine();
			foreach (var item in dict)
			{
				Console.WriteLine($"{item.Key} -> {item.Value} вхождений");
			}

			Console.WriteLine("Нажмите любую клавишу");
			
			Console.ReadKey();
		}
	}

	public static class Message
	{

		/// <summary>
		/// Получение в массив слов, длина которых не превышает указанный лимит
		/// </summary>
		/// <param name="Phrase">Обрабатываемая строка</param>
		/// <param name="WordLength">Отбрасываются все слова, длина которых превышает это значение</param>
		/// <returns>Массив слов, длина которых не превышает <paramref name="WordLength"/>, включая знаки препинания</returns>
		public static string[] GetWordsShorter(string Phrase, int WordLength)
		{
			List<string> res = new List<string>();
			foreach (string item in Phrase.Split(new char[] { ' ' }))
			{
				if (item.Length <= WordLength)
				{
					res.Add(item);
				}
			}
			return res.ToArray();
		}

		/// <summary>
		/// Удаление из строки слов, оканчивающихся на указанный символ
		/// </summary>
		/// <param name="Phrase">Обрабатываемая строка</param>
		/// <param name="FinalSymbol">Слова, оканчивающиеся на этот символ, будут исключены из результирующей строка</param>
		/// <returns>Строка без слов, оканчивающихся на <paramref name="FinalSymbol"/></returns>
		public static string EraseWordsEndedWith(string Phrase, char FinalSymbol)
		{
			List<string> lst = new List<string>();
			string res = string.Empty;
			foreach (string item in Phrase.Split(new char[] { ' ' }))
			{
				if (item[item.Length - 1] != FinalSymbol)
				{
					lst.Add(item);
				}
			}
			if (lst.Count > 0)
			{
				res = lst[0];
				for (int i = 1; i < lst.Count; i++)
				{
					res += " " + lst[i];
				}
			}
			return res;
		}

		/// <summary>
		/// Получение самого длинного слова из фразы
		/// </summary>
		/// <param name="Phrase">Обрабатываемая строка</param>
		/// <returns>Самое длинное слово, включая знаки препинания</returns>
		public static string GetLongestWord(string Phrase)
		{
			string[] lst = Phrase.Split(new char[] { ' ' });
			string res;

			if (lst.Length > 0)
			{
				res = lst[0];
				int len = res.Length;
				for (int i = 1; i < lst.Length; i++)
				{
					if (lst[i].Length > len)
					{
						res = lst[i];
						len = lst[i].Length;
					}
				}
			}
			else res = Phrase;
			return res;
		}

		/// <summary>
		/// Составляет строку из слов, длины которых превышают <paramref name="MinLen"/>
		/// </summary>
		/// <param name="Phrase">Обрабатываемая строка</param>
		/// <param name="MinLen">Слово должно иметь длину более указанной, включая знак препинания</param>
		/// <returns></returns>
		public static string LongerWords(string Phrase, int MinLen)
		{
			StringBuilder sb = new StringBuilder();
			foreach (string item in Phrase.Split(new char[] { ' ' }))
			{
				if (item.Length > MinLen)
				{
					if (sb.Length == 0)
						sb.Append(item);
					else
						sb.Append(" " + item);
				}
			}
			return sb.ToString();
		}

		/// <summary>
		/// Составление новой строки на основании самых длинных слов в предложении.
		/// Слова разделяются пробелами. В расчете длины слова участвуют знаки препинания
		/// </summary>
		/// <param name="Phrase">Обрабатываемая строка</param>
		/// <returns>Строка из самых длинных слов, разделенных пробелами</returns>
		public static string LongerWords(string Phrase)
		{
			int len = GetLongestWord(Phrase).Length;
			StringBuilder sb = new StringBuilder();
			foreach (string item in Phrase.Split(new char[] { ' ' }))
			{
				if (item.Length == len)
				{
					if (sb.Length == 0)
						sb.Append(item);
					else
						sb.Append(" " + item);
				}
			}
			return sb.ToString();
		}

		/// <summary>
		/// Производит частотный анализ текста.
		/// </summary>
		/// <param name="Phrase">Текст, для которого надо провести частотный анализ</param>
		/// <param name="StringArray">Перечень слов, частота вхождения которых выводится в качестве результата</param>
		/// <returns>Количество вхождений каждого слова из <paramref name="StringArray"/> в <paramref name="Phrase"/>. Регистр при обработке игнорируется</returns>
		public static Dictionary<string, int> FreqAnalytics(string Phrase, string[] StringArray)
		{
			string[] phrArray = Phrase.ToLower().Split(new char[] { ' ' });

			Dictionary<string, int> res = new Dictionary<string, int>();

			for (int i = 0; i < StringArray.Length; i++)
			{
				if (!res.ContainsKey(StringArray[i]))
					res.Add(StringArray[i], 0);
			}

			for (int i = 0; i < phrArray.Length; i++)
			{
				if (res.ContainsKey(phrArray[i]))
				{
					res[phrArray[i]] += 1;
				}
			}
			return res;
		}
	}
}