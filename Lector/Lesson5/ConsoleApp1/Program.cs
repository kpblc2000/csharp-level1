using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	struct Worker
	{
		static Random r = new Random();
		static int id = 1;
		static public Worker GetWorker()
		{
			return new Worker()
			{
				Age = r.Next(14, 100),
				Salary = r.Next(8000, 100000),
				Name = $"DefaultName_ {id++}"
			};

		}

		public int Age { get; set; }
		public int Salary { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return $"{Name,-20} {Age,-5} {Salary,-10}";
		}

	}

	delegate int Rule(Worker w1, Worker w2);

	class Program
	{

		static void Main(string[] args)
		{
			Worker[] workers = new Worker[]
				 {
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
					 Worker.GetWorker(),
				 };
			foreach (var item in workers) Console.WriteLine(item);

			//Array.Sort(workers, RuleSortWorkerSalary);

			//Console.WriteLine();

			//foreach (var item in workers) Console.WriteLine(item);

			//Array.Sort(workers, RuleSortWorkerAge);

			//Console.WriteLine();

			//foreach (var item in workers) Console.WriteLine(item);
			Console.WriteLine();
			var r = Array.FindAll(workers, SearchSalary);
			foreach (var item in r) Console.WriteLine(item);
		}

		private static bool SearchAge(Worker obj)
		{
			return obj.Age > 50;
		}

		private static bool SearchSalary(Worker obj)
		{
			return obj.Salary > 50000;
		}

		static int RuleSortWorkerSalary(Worker w1, Worker w2)
		{
			return w1.Salary > w2.Salary ? 1 : -1;
		}

		static int RuleSortWorkerAge(Worker w1, Worker w2)
		{
			return w1.Age > w2.Age ? 1 : -1;
		}
	}
}
