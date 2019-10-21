using System;

namespace Lab2_area_and_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {

            double width, height, length;
            string input;
            do
            {                              
                Console.WriteLine("So you're gonna want some classroom dimensions? Cool, first enter the room's width (as a number!)");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nNow enter the room's length, please (also as a number only!)");
                length = Convert.ToDouble(Console.ReadLine());

               
                
                    Console.WriteLine("\nGo ahead and enter the room's height (if it isn't obvious, i need a number only!)");
                    height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nYou've got it crankin, cuz your VOLUME is " + (length *height * width));
                       
                                             
                
                Console.WriteLine("\nYour room's AREA is " + length * width);

                Console.WriteLine("\nYour room's PERIMETER is " + (length + width) * 2);

                
                do
                {
                    Console.WriteLine("\nYou wanna do this again? answer 'y' or 'n' ");
                    input = Console.ReadLine();

                    if (input == "n")
                    {
                        Console.WriteLine("\nWell, have a good night!");
                        return;
                    }
                    else if (input == "y")
                    {
                        Console.WriteLine("OK, cool. Let's begin again");
                    }
                    else
                    {
                        Console.WriteLine("You've entered something else. Please try again");
                    }
                }
                while (input != "y");
            }
            while (input == "y");
        














            }       
    }
}
