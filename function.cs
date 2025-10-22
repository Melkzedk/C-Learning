using System;

public static class FunctionExample
{
  public static void Run()
  {
    int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    int myNum1 = PlusMethodInt(8, 5);
    double myNum2 = PlusMethodDouble(4.3, 6.26);
    Console.WriteLine("Int: " + myNum1);
    Console.WriteLine("Double: " + myNum2);
  }
}