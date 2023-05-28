using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            double X, Y;

            Console.WriteLine("Choose your operation");
            Console.WriteLine("----------------------------");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("^");
            Console.WriteLine("sin");
            Console.WriteLine("cos");
            Console.WriteLine("tan");
            Console.WriteLine("sqroot");


            string operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    Console.WriteLine("Enter first integer");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    B = Convert.ToInt32(Console.ReadLine());
                    C = A + B;
                    Console.WriteLine("Sum = {0}", C);
                    break;

                case "-":
                    Console.WriteLine("Enter first integer");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    B = Convert.ToInt32(Console.ReadLine());
                    C = A - B;
                    Console.WriteLine("Subtraction = {0}", C);
                    break;

                case "*":
                    Console.WriteLine("Enter first integer");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    B = Convert.ToInt32(Console.ReadLine());
                    C = A * B;
                    Console.WriteLine("Multiplication = {0}", C);
                    break;

                case "/":
                    try
                    {
                        Console.WriteLine("Enter first integer");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second integer");
                        B = Convert.ToInt32(Console.ReadLine());
                        C = A / B;
                        Console.WriteLine("Division = {0}", C);
                    }
                    catch
                    {
                        Console.WriteLine("Cannot divide by 0");
                    }
                    break;

                case "^":
                    Console.WriteLine("Enter first integer");
                    A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer");
                    B = Convert.ToInt32(Console.ReadLine());
                    C = (int)Math.Pow(A, B);
                    Console.WriteLine("Power = {0}", C);
                    break;

                case "sin":
                    Console.WriteLine("Enter number");
                    X = Convert.ToDouble(Console.ReadLine());
                    Y = (X * (Math.PI)) / 180;
                    Console.WriteLine("The sin of {0} is {1}", X, Math.Sin(Y));
                    break;

                case "cos":
                    Console.WriteLine("Enter number");
                    X = Convert.ToDouble(Console.ReadLine());
                    Y = (X * (Math.PI)) / 180;
                    Console.WriteLine("The cos of {0} is {1}", X, Math.Cos(Y));
                    break;

                case "tan":
                    Console.WriteLine("Enter number");
                    X = Convert.ToDouble(Console.ReadLine());
                    Y = (X * (Math.PI)) / 180;
                    Console.WriteLine("The tan of {0} is {1}", X, Math.Tan(Y));
                    break;
                
                case "sqroot":
                    Console.WriteLine("Enter number");
                    X = Convert.ToDouble(Console.ReadLine());
                    Console.Write("The square root of {0} is {1}", X, Math.Sqrt(X));
                    break;
                  
            }
        }
    }
}
