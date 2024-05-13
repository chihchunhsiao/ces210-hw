using System;


class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); 
        
        // Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        
        // Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        Fraction f3 = new Fraction(3, 4);
        
        // Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        
        // Console.WriteLine($"{f4.GetTop()}/{f4.GetBottom()}");

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
        
          
}         
