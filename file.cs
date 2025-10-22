using System;
using System.IO;

class Program
{
    static void Main()
    {
        string writeText = "Hello World!";
        File.WriteAllText("filename.txt", writeText);

        string readText = File.ReadAllText("filename.txt");
        Console.WriteLine(readText);

        const string constString = "This is a constant string.";
        Console.WriteLine(constString);
    }
}
