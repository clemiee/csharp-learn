using System;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else decision

            /*
            Console.WriteLine("Matt's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3 : ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                message = "Sorry, we didn't understand. ";
                //message = message + "You lose!";
                message += "You lose!";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Matt's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3 : ");
            string userValue = Console.ReadLine();

            // if else conditional operator in one line
            string message = (userValue == "1") ? "boat" : "strand of lint";


            // too long, use the code next line
            //Console.Write("You won a");
            //Console.Write(message);
            //Console.Write(".");

            // literal strings, lesser ones
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
