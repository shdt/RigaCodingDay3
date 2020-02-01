using System;

namespace Day3_if
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("insert first digit");
			string input = Console.ReadLine();
			int a = Convert.ToInt32(input);

			Console.WriteLine("insert 2nd digit");
			input = Console.ReadLine();
			int b = Convert.ToInt32(input);

			Console.WriteLine("insert 3rd digit");
			input = Console.ReadLine();
			int c = Convert.ToInt32(input);

			if (a > b && a > c)
			{
				Console.WriteLine("1st was the largest" + a);
			}
			else if (b > a && b > c)
			{
				Console.WriteLine("2nd was the largest" + b);
			}
			else if (c > a && c > b)
			{
				Console.WriteLine("3rd was the largest" + c);
			}
			else if (a == b || b == c || c == b)
			{
				Console.WriteLine("2 of them were equal" + a);
			}
			else
			{
				Console.WriteLine("all are equal");
			}



		}

		static void NestingIf()
		{
			int a = 5;
			int b = 6;

			// && AND
			// || OR

			if (a >= 5 && b == 6)
			{

			}

			int digit = 5;

			if (digit > 5)
			{
				Console.WriteLine("#");
			}
			else if (digit < 5)
			{
				Console.WriteLine("##");
			}
			else
			{
				Console.WriteLine("###");
			}

		}

		static void Calc()
		{
			Console.WriteLine("Insert first digit");
			string input = Console.ReadLine();
			int a = Convert.ToInt32(input);


			Console.WriteLine("+ or - or * or /");
			string math = Console.ReadLine();

			Console.WriteLine("insert 2nd digit");
			input = Console.ReadLine();
			int b = Convert.ToInt32(input);

			double result = 0;

			if (math == "+")
			{
				result = a + b;
			}
			else if (math == "-")
			{
				result = a - b;
			}
			else if (math == "*")
			{
				result = a * b;
			}
			else if (math == "/")
			{
				result = a / b;
			}
			else
			{
				Console.WriteLine("incorrect mathematical action action");
			}

			Console.WriteLine("Result: " + result);
		}
	}
}
