using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int num = randomnumber.Next(1, 7);             // * 1 to 6 because 7 is exclusive
        System.Console.WriteLine(num);                 // * Output: Random number between 1 to 6


        double num2 = randomnumber.NextDouble(1, 50);       // * Random number between 0 to 50, can be decimal
        System.Console.WriteLine(num2);                     // * Output: Random number between 0 to 50

        int dice1 = randomnumber.Next(1, 7);
        int dice2 = randomnumber.Next(1, 7);
        int dice3 = randomnumber.Next(1, 7);
        int result = dice1 + dice2 + dice3;
        
        System.Console.WriteLine($"Dice 1: {dice1}, Dice 2: {dice2}, Dice 3: {dice3}, Total: {result}");
        // * example output : Dice 1: 3, Dice 2: 5, Dice 3: 2, Total: 10
    }
}