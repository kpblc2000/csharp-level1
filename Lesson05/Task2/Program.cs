using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{

			string a1 = "abcd";
			string b1 = "dcba";
			string c1 = "";
			foreach (var item in a1.Reverse())
			{
				c1 += item;
			}
			Console.WriteLine(c1 == b1);

			string msg = "Проверка работы обработки";
			string[] shortRes = Message.GetWordsShorter(msg, 8);

			foreach (string item in msg.Split(new char[] { ' ' }))
			{
				Console.WriteLine("{0} -> {1}", item, item.Length);
			}

			//foreach (string elem in msg.Split(new char[] { ' ' })) ;
			//{
			//	Console.WriteLine($"{elem} -> {elem.Length}");
			//}

			foreach (string item in shortRes)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine($"Без оканчивающихся на 'и' : {Message.EraseWordsEndedWith(msg, 'и')}");
			Console.WriteLine($"Самое длинное слово : {Message.GetLongestWord(msg)}");
			Console.WriteLine($"Слова длиннее 6 символов : {Message.LongerWords(msg, 6)}");



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
					{
						sb.Append(item);
					}
					else
						sb.Append(" " + item);
				}
			}
			return sb.ToString();
		}
	}
}