using System;

namespace Day3_methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("#1 Insert 2 digits on separate lines:");
			string input = Console.ReadLine();
			int a = Convert.ToInt32(input);
			input = Console.ReadLine();
			int b = Convert.ToInt32(input);

			Method1(a, b);

			Console.WriteLine("#2Result: " + Method2());

			Console.WriteLine("#3Result: " + Method3(a, b));

		}

		static void Method1(int a, int b)
		{
			int result = a + b;
			Console.WriteLine("#1Result: " + result);
		}

		static int Method2()
		{
			Console.WriteLine("#2 Insert 2 digits on separate lines:");
			string input = Console.ReadLine();
			int a = Convert.ToInt32(input);
			input = Console.ReadLine();
			int b = Convert.ToInt32(input);

			return a + b;
		}

		static int Method3(int a, int b)
		{
			Console.WriteLine("Reusing var from #1");
			int result = a + b;
			return result;
		}




		static void Ex1()
		{
			Console.WriteLine("void method output");
			Ex2();
		}
		static void Ex2()
		{
			Console.WriteLine("2nd void method output");
		}

		static void Ex3(int a, int b)
		{
			Console.WriteLine(a + b);
		}

		static int Ex4()
		{
			int a = 5;
			int b = 6;

			return a + b;
		}
	}
}
