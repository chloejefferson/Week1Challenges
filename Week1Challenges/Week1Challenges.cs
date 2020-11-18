using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenges
{
    class Week1Challenges
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables that hold your first name, last name, and age

            string firstName = "Chloe";
            string lastName = "Jefferson";
            int age = 26;

            Console.WriteLine($"Hello, my name is {firstName} {lastName} and I am {age} years old.");

            //Declare and initialize an array that holds a collection of at least four of your favorite book or movie titles

            string[] favoriteMovieMusicalsArray = { "Hamilton", "Sweeney Todd", "Across the Universe", "Hairspray" };

            //Make a list to hold dates. Include on that list the current date and time.

            List<string> listOfDates = new List<string>();
            DateTime now = DateTime.Now;
            string nowString = now.ToString("dd/MM/yyyy HH:mm:ss");
            string randomDateTime1 = "11/01/2020 08:33:18";
            string randomDateTime2 = "30/10/2001 18:01:02";
            
            listOfDates.Add(nowString);
            listOfDates.Add(randomDateTime1);
            listOfDates.Add(randomDateTime2);
           
            Console.WriteLine(nowString);

            //Write out to the Console the values calculated by your age variable and the number 7. Use each operator we covered in Operators

            int seven = 7;
            int sum = age + seven;
            Console.WriteLine(sum);
            int diff = age - seven;
            Console.WriteLine(diff);
            int prod = age * seven;
            Console.WriteLine(prod);
            int quot = age / seven;
            Console.WriteLine(quot);
            int remainder = age % seven;
            Console.WriteLine(remainder);


            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            int sleepHours = 11;

            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
                    }
            else if (sleepHours < 10 && sleepHours > 8)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (sleepHours < 8 && sleepHours > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            Console.WriteLine("How is your day today? Tell me if it is great, good, ok, bad or :(");

            string howIsYourDay = Console.ReadLine();

            switch (howIsYourDay)
            {
                case "great":
                    Console.WriteLine("That's fantastic!");
                    break;
                case "good":
                    Console.WriteLine("Wow, me too!");
                    break;
                case "ok":
                    Console.WriteLine("It's ok to be ok.");
                    break;
                case "bad":
                    Console.WriteLine("A bad day can always get better!");
                    break;
                case ":(":
                    Console.WriteLine("Keep your head up!");
                    break;
                default:
                    //--Enter your catchall code. This is like "else" for switch cases
                    Console.WriteLine("Sorry, I didn't understand your reponse. Did you write a response EXACTLY as listed in the introduction?");
                    break;
            }

            Console.ReadLine();

        }
    }
}
