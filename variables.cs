using System;

class Program
{
    static void Main(string[] args)
    {
        int age = 22;
        string name = "Thomas";
        string message = "Hello, World!";
        int x = 10;
        int agex = x + age;
        double pi = 3.14;
        bool alive = true;
        char symbol = '@';
        string presentation = "My name is " + name + " and i am " + age + " years old";

////////////////////////////////////////////////////////////////////

        System.Console.WriteLine(age);
        System.Console.WriteLine(x);
        System.Console.WriteLine(name);
        System.Console.WriteLine(message);
        System.Console.WriteLine(agex);

        System.Console.WriteLine("My name is " + name);
        System.Console.WriteLine("the value of pi is " + pi + " and the value of x is " + x);
        System.Console.WriteLine("Am i alive ? " + alive + " this is what i thought");
        System.Console.WriteLine("This is a symbol " + symbol + " and this is a number " + x);
        System.Console.WriteLine(presentation);

        string userName = symbol + name;
        System.Console.WriteLine(userName);
    }
}
