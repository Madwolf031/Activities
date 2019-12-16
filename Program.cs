using System;

namespace Simple_Calculator__Lamparas_
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string useoper;


            Console.WriteLine("Console Simple Calculator\n\n\n");

            Console.WriteLine("Enter the first number");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            secondnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator: + - x /");
            useoper = Console.ReadLine();


            if (useoper == "+")
			{
                answer = firstnum + secondnum;
                Console.WriteLine("\nAnswer:" + answer);
            }

            else if (useoper == "-")
			{
                answer = firstnum - secondnum;
                Console.WriteLine("\nAnswer:" + answer);
            }


            else if (useoper == "*")
			{
                answer = firstnum + secondnum;
                Console.WriteLine("\nAnswer:" + answer);
            }

            else if (useoper == "/")
			{
                answer = firstnum + secondnum;
                Console.WriteLine("\nAnswer:" + answer);
            }

            else
            {
                Console.WriteLine("Invalid input of operator");
            }

            Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
        }
    }
}
