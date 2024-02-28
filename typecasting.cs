using System;

class Program
{
    static void Main(string[ args])
    {
        // * Type casting: coverting a variable from one type to another
        // *               useful when we accept an input from the user
        // *               and we want to convert it to a different type 

        double a = 3.14;
        int b = Convert.toInt32(a);
        Console.WriteLine(b); // * input is 3
        Console.WriteLine(a); // * input is 3.14
        Console.WriteLine(a.GetType()); // * input is System.Double
        Console.WriteLine(b.GetType()); // * input is System.Int32


        int c = 123;
        double d = Convert.ToDouble(c) + 0.1;
        Console.WriteLine(c); // * input is 123
        Console.WriteLine(d); // * input is 123.1
        Console.WriteLine(c.GetType()); // * input is System.Int32
        Console.WriteLine(d.GetType()); // * input is System.Double


        int e = 321;
        string f = Convert.ToString(e);
        Console.WriteLine(e); // * input is 321
        Console.WriteLine(f); // * input is 321
        Console.WriteLine(e.GetType()); // * input is System.Int32
        Console.WriteLine(f.GetType()); // * input is System.String

        string g = "A";
        char h = Convert.ToChar(g);
        Console.WriteLine(g); // * input is A
        Console.WriteLine(h); // * input is A
        Console.WriteLine(g.GetType()); // * input is System.String
        Console.WriteLine(h.GetType()); // * input is System.Char

        string i = "true";
        bool j = Convert.ToBoolean(i);
        Console.WriteLine(i); // * input is true
        Console.WriteLine(j); // * input is True
        Console.WriteLine(i.GetType()); // * input is System.String
        Console.WriteLine(j.GetType()); // * input is System.Boolean

        // * Note:
        // * 1. The Convert class is a part of the System namespace
        // * 2. The Convert class has a method for each type
        // * 3. The method name is the type name
        // * 4. The method accepts a single parameter of the type to convert
        // * 5. The method returns the converted value
        
    }
}