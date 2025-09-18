using System;

public class HelloWorld
{
    static void MyMethod() 
    {
       int a = 30;
       int b = 25;
       int c = a + b;
       Console.WriteLine(c);
    }

    public static void Main(string[] args)
    {
        MyMethod();
        MyMethod();
    }
}
