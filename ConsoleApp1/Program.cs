using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User need to input 2 numbers and the program displays all the operations on the numbers!");

            int Input1;
            int Input2;
            Console.WriteLine("Enter value 1");
            Input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            Input2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum is {Add(Input2, Input1)}");
            Console.WriteLine($"The subtraction is {Sub(Input1, Input2)}");
            Console.WriteLine($"The multiplication is {Mul(Input1, Input2)}");
            Console.WriteLine("The division is ");
            Div(Input1 ,Input2);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static void Div(int a, int b)
        {
            if (b == 0) Console.WriteLine("Not possible to divide by zero");
            else Console.WriteLine(a / b);
        }
    }
}
