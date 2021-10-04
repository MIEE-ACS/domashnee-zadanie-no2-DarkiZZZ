using System;

// 18ый вариант( т.к. по списку 21ый, но его нет)

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2;
            Console.Write("First of all, enter radius of circles(there are two of them and R1 = 1, R2 = 2)\nRadius1: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius2: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            if (r1 < 1 || r2 < 2)
            {
                Console.Write("Such values have consequences. There will be undefined Y values. Are you sure you wanna " +
                    "continue?(Yes or No): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Yes":
                        break;
                    case "No":
                        Console.WriteLine("Okay.Standard values will be calculated.");
                        r1 = 1;
                        r2 = 2;
                        break;
                    case "or":
                        Console.WriteLine("Looks like we have genious here...");
                        r1 = 1;
                        r2 = 2;
                        break;

                }
            }
            else if (r1 > 1 || r2 > 2)
            {
                Console.WriteLine("No way. There will be too much Y values. I will limit radiuses' values " +
                    "to standard ones ");
                r1 = 1;
                r2 = 2;
            }
            PrintingOneValue(r1, r2);
            PrintingAllValues(r1, r2);
        }

        private static void PrintingOneValue(double r1, double r2)
        {
            Console.Write("Enter X values for certain Y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write($"For {x} it will be: ");
            if (x < -3)
            {
                Console.WriteLine("Function is undefined");
            }
            else if (x >= -3 && x < -2)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
            }
            else if (x >= -2 && x < 0)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(r1, x));
            }
            else if (x >= 0 && x < 4)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(r2, x));
            }
            else if (x >= 4 && x < 6)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x));
            }
            else if (x >= 6 && x < 7)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
            }
            else if (x > 7)
            {
                Console.WriteLine("Function is undefined");
            }
        }

        private static double PrintingAllValues(double r1, double r2)
        {
            Console.WriteLine("The list of all 'X to Y' values: ");
            double x;
            for (x = -3; x <= 7; x += 0.2)
            {
                if (x < -3)
                {
                    Console.WriteLine("Function is undefined");
                }
                else if (x >= -3 && x < -2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x));
                }
                else if (x >= -2 && x < 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(r1, x));
                }
                else if (x >= 0 && x < 4)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(r2, x));
                }
                else if (x >= 4 && x < 6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x));
                }
                else if (x >= 6 && x < 7)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment5(x));
                }
                else if (x > 7)
                {
                    Console.WriteLine("Function is undefined");
                }
            }

            return x;
        }

        static double segment1(double x)
        {
            double y;
            y = -x - 2;
            return y;
        }
        
        static double segment2(double r1, double x)
        {
            double y;
            y = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow((x + 1), 2));
            return y;
        }

        static double segment3(double r2, double x)
        {
            double y;
            y = Math.Sqrt(Math.Pow(r2, 2) - Math.Pow((x - 2), 2));
            return -y;
        }

        static double segment4(double x)
        {
            double y;
            y = 2 - x / 2;
            return y;
        }

        static double segment5(double x)
        {
            double y;
            y = -1;
            return y;
        }
    }
}
