using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Returns Hello + user input of name
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.ReadLine();


            //Returns area of a rectangle with user input
            Console.WriteLine("What is the length of the rectangle?");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            Console.WriteLine("What is the width of the rectangle?");
            input = Console.ReadLine();
            int width = int.Parse(input);
            Console.WriteLine("The area of the rectangle is " + length * width);
            //Console.ReadLine();

            //Returns MPG with user input
            Console.WriteLine("How many miles have you driven today?");
            string milesDriven = Console.ReadLine();
            float miles = float.Parse(milesDriven);
            Console.WriteLine("How many gallons have you used today?");
            string gallonsUsed = Console.ReadLine();
            float gallons = float.Parse(gallonsUsed);
            Console.WriteLine("Your miles per gallon is " + gallons / miles);
            //Console.ReadLine();

            //Case-insensitive string search
            string passage = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a phrase or partial phrase: ");
            string phrase = Console.ReadLine();
            if (!passage.ToLower().Contains(phrase.ToLower()))
            {
                Console.WriteLine("Sorry, this passage does not contain this phrase. Try again!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You found it!");
                Console.ReadLine();
            }


        }
    }
}
