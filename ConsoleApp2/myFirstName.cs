using System;

namespace ConsoleApp2
{
    class myFirstName
    {
        static void Main(string[] args)
        {

            /*
            int x;
            int y;

            x = 7;
                y = x + 3;
                Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
                Console.Write("type your first name:");
                String myFirstName;
            myFirstName = Console.ReadLine();


            string myLastName;
            Console.Write("type your last name:");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
