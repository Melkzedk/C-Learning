using System;

public class Vehicle  // base class (parent)
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

public class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

public static class InheritanceExample
{
    public static void Run()
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}
