using System;

public static class MethodExample
{
	public static void Run()
	{
		int a = 30;
		int b = 25;
		int c = a + b;

		Console.WriteLine(c);   // prints 55
		Console.WriteLine(c);   // prints 55 again
	}
}
