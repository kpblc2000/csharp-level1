using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3a
{

	class Program
	{
		static void Main()
		{
			Random rnd = new Random();

			Fraction[] ar = new Fraction[5]; // new Fraction[rnd.Next(20)];
			
			for (int i = 0; i < ar.Length; i++)
			{
				try
				{
					ar[i] = new Fraction(rnd.Next(-20, 20), rnd.Next(-20, 20));
				}
				catch
				{
					--i;
				}
			}

			Fraction sum = new Fraction();
			Fraction multi = new Fraction(1, 1);

			for (int i = 0; i < ar.Length; i++)
			{
				Console.WriteLine(ar[i]);
				sum += ar[i];
				multi *= ar[i];
			}

			Console.WriteLine("Summ = {0:N4}; value = {1:N4}", sum, sum.Value);
			Console.WriteLine("Multiple = {0}; value = {1:N4}", multi, multi.Value);

			Console.ReadKey();
		}
	}
}
