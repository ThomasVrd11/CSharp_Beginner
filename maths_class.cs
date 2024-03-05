using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 3;
        double a = Math.Pow(x, 2);
        System.Console.WriteLine(a);
        // * input 9

        double b = Math.Sqrt(x);
        System.Console.WriteLine(b);
        // * input 1.7320508075688772

        double c = Math.Abs(x);
        System.Console.WriteLine(-5);
        // * input 5

        double xx = 5.5;
        double d = Math.Round(xx);
        System.Console.WriteLine(d);
        // * input 6
        double xxx = 5.1;
        double e = Math.Ceiling(xxx);
        System.Console.WriteLine(e);
        // * input 6

        double xxxx = 5.9;
        double f = Math.Floor(xxxx);
        System.Console.WriteLine(f);
        // * input 5

        double y = 3.99;
        double yy = 5;
        double g = Math.Max(y, yy);
        System.Console.WriteLine(g);
        // * input 5
        
    }
}