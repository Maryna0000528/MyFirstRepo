using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "Hey you! What is you name??";
            // Console.WriteLine(word);

            //string answer = Console.ReadLine();
            //Console.WriteLine("well, hello! " + answer);

            //int x;
            //x = 7;
            //int x = 7;
            //Console.WriteLine(x-3);
            //x = 5;
            //Console.WriteLine(x*10);
            //Console.WriteLine(3+5);
            //int x = 10;
            //int y = 7;
            //Console.WriteLine(x % y );

           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

            // Console.WriteLine(a + b);
            // Console.WriteLine(a - b);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a / b);

            string oper = Console.ReadLine();

            if (oper == "+")

                Console.WriteLine("a + b");

            else if (oper == "-")

                Console.WriteLine("a - b");

            else if (oper == "a * b")

                Console.WriteLine("a * b");

            else if (oper == "a / b")

                Console.WriteLine("a / b");

            else

                Console.WriteLine("wrong operator!");


      



           


        }
    }
}
