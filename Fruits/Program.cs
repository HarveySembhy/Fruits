using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to order today? \n Apple, Banana, Cat, Dog, Egg?");            
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "apple")
            {
                message = "You chose an Apple!";                
            }
            else if (userValue == "banana")
            {
                message = "You chose a Banana!";
            }
            else if (userValue == "cat")
            {
                message = "Meow Meow Meow!";
            }
            else if (userValue == "dog")
            {
                message = "Woof Woof Woof!";
            }
            else if (userValue == "eggs")
            {
                message = "Do you like it sunny side up, over-easy, scrambled or pouched?";
            }
            else
            {
                message = "I'm sorry I didn't catch that, please try again.";
            }

            Console.WriteLine(message);
            Console.WriteLine("\n Thanks for shopping with us! Press any key to close.");
            Console.ReadLine();



            /*
            Values - Apple, Banana, Cat, Dog, Egg

            If Apple is submitted - show "You chose an Apple!"
            If Banana is submitted - show "You chose a Banana!"
            If Cat is submitted - show "Meow Meow Meow!"
            If Dog is submitted - show "Woof Woof Woof!"
            If Egg is submitted - show "Do you like it sunny side up, over-easy, scrambled or pouched?"
            If anythying else is submitted - show "I'm sorry I don't understand"

            */

            /*
            string term = "Apple"; apple Apple ApPle APPLE 

            switch (term.ToUpper())
            {
                case "APPLE":
                    Console.WriteLine("woo apple");
                    break;
                case "BANANA":
                    Console.WriteLine("woo banana");
                    break;
                case "CAT":
                    Console.WriteLine("woo cat");
                    break;
                case "DOG":
                    Console.WriteLine("woo dog
                case "EGG":
                    Console.WriteLine("woo egg");
                    break;
                default:
                    //default behavior if nothing matches aka out of bounds inputs
                    break;
            }
            */
        }
    }
}
