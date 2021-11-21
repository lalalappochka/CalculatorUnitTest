using System;

namespace calculator
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                int x = 5;
                int y = 8;
                Console.WriteLine(calculator.Sum(x, y));
                Console.WriteLine(calculator.Subtract(x, y));
                Console.WriteLine(calculator.Multiply(x, y));
                Console.WriteLine(calculator.Divide(x, y));
                Console.WriteLine(calculator.Pow(x, y));

                try
                {
                    Console.WriteLine(calculator.Divide(x, 0));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        
    }
}
