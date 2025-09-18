using System;

class Program
{
    static void Main(string[] args)
    {
        MyMethod();
    }

    static void MyMethod()
    {
        Console.WriteLine(MyMethod());
    }
}
