using System;

namespace Day3_methods
{
	class Program
	{
		static int seq = 1;
		static void Main(string[] args)
		{

			Random r = new Random();
			int a = r.Next(1, 7);
			Console.WriteLine(a);
			Console.WriteLine(Enum.GetName(typeof(DayOfWeek),a));
			Console.ReadLine();

		}

		static void InputTrueFalse()
		{
			int input1 = AskInput();
			Console.WriteLine(MethodTrueFalse(input1));
		}

			static bool MethodTrueFalse(int a)
		{
			bool b = true;
			if (a > 0)
			{
				return b;
			}
			else
			{
				return !b;
			}

		}

		static void RefactorBiggest()
		{
			//Cilveks ievada tris skaitlus- int
			//Jaizvada lielakais

			int skaitlis1 = AskInput();
			int skaitlis2 = AskInput();
			int skaitlis3 = AskInput();

			int biggest = 0;
			biggest = BiggestofTwo(skaitlis1, skaitlis2);
			biggest = BiggestofTwo(skaitlis3, biggest);

			Console.WriteLine("Rezultats ir " + biggest);

		}

		static int AskInput()
		{
			Console.WriteLine($"Ievadiet skaitli #{seq}!");
			int result = InputToDigit();
			seq++;
			return result;
		}

		static int InputToDigit()
		{
			return Convert.ToInt32(Console.ReadLine());
		}

		static int BiggestofTwo(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			else
			{
				return b;
			}
		}



		static void Methods3to1()
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
