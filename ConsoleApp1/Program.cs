using System;

namespace learn
{
    class Program
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
            Console.Write("Nama Awal: ");
            string firstName;
            firstName = Console.ReadLine();

            //string last;
            //Console.Write("Nama Akhir: ");
            //last = Console.ReadLine();

            Console.Write("Nama Akhir: ");
            string myLastName = myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
