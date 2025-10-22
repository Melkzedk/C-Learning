using System;

public static class IfElseExample
{
    public static void Run()
    {
        int Age = 20;

        if (Age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else
        {
            Console.WriteLine("You are an adult.");
        }
    }
}