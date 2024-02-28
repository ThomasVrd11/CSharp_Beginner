using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("What is your name?");
        string name = Console.ReadLine(); // * store input in variable name

        System.Console.WriteLine("Whats your age?");
        int age = Convert.ToInt32(Console.ReadLine()); // * store input in variable age

        System.Console.WriteLine("Whats your salary?");
        double salary = Convert.ToDouble(Console.ReadLine()); // * store input in variable salary

        System.Console.WriteLine("So your name is " + name + ", you are " + age + " years old, and your salary is " + salary + " euros");
        


    }
}