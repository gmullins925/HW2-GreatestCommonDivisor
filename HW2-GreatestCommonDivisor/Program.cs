using System;

public class Program
{
	static int GCD(int a, int b)
	{
		int Remainder;
		 
		while (b != 0)
		{
			// single equal sign is assigning a value, dbl equal is compairing the 2
			Remainder = a % b; //a divided by b = *** with remainder of (new value for "Remainder")
			a = b;	//assigns value of variable "b" to the variable "a"
			b = Remainder; ////assigns value of variable "Remainder" to the variable "b"
		}

		return a;
	}

	static int Main(string[] args)
	{
		int x, y;

		Console.WriteLine("This program allows calculating the GCD");
		Console.Write("Value 1: ");
		x = int.Parse(Console.ReadLine());
		Console.Write("Value 2: ");
		y = int.Parse(Console.ReadLine());


		Console.Write("\nThe Greatest Common Divisor of ");
		Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));

		Console.ReadLine();

		return 0;

		
	}
}