using System;

namespace HomeWorkWeek1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int a = r.Next(1, 7);
			Console.WriteLine(a);
			Console.WriteLine(Enum.GetName(typeof(DayOfWeek), a));
			Console.ReadLine();
			DayOfWeek(a);
			Console.ReadLine();
		}

		static void DayOfWeek(int a)
		{
			if (a == 1)
			{
				Console.WriteLine("It's Monday");
			}
			else if(a == 2)
			{
				Console.WriteLine("It's Tuesday");
			}
			else if (a == 3)
			{
				Console.WriteLine("It's Wednesday");
			}
			else if (a == 4)
			{
				Console.WriteLine("It's Thursday");
			}
			else if (a == 5)
			{
				Console.WriteLine("It's Friday");
			}
			else if (a == 6)
			{
				Console.WriteLine("It's Saturday");
			}
			else
			{
				Console.WriteLine("It's Sunday");
			}
		}
	}
}
