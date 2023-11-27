using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22_2
{
    using System;

    public delegate T Operation<T>(T x, T y);

    class Program
    {
        static void Main()
        {
            // Create instances of Operation<T> delegate for each operation
            Operation<int> addDelegate = Add;
            Operation<int> subtractDelegate = Subtract;
            Operation<int> multiplyDelegate = Multiply;
            Operation<int> divideDelegate = Divide;

            // Ask the user to input two values of the same data type
            Console.Write("Enter the first value: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to choose an operation
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation and display the result
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {addDelegate(value1, value2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {subtractDelegate(value1, value2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {multiplyDelegate(value1, value2)}");
                    break;
                case 4:
                    Console.WriteLine($"Result: {divideDelegate(value1, value2)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }

        // Implement the static methods for each operation
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }
    }

}
