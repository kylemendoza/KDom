using System;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tSimple Calculator");

            Console.WriteLine("\t\t\tEnter First Number: ");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an Operator: ");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter Second Number: ");
            secondnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write(answer);
            }
            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write(answer);
            }
            if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write(answer);
            }
            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write(answer);

            }

            
            Console.ReadKey();
    
            
        }
    }
}
