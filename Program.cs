using System;

namespace Lab2_area_and_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double length, width,  height;
            string input;
            do
            {
                do
                {
                    Console.WriteLine("So you're gonna want some classroom dimensions? Cool, first enter the room's width (as a number!)");
                    width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("Now enter the room's length, please (also as a number only!)");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("And now enter the room's height (if it isn't obvious, i need a number only!)");
                    height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("Your room's area is " + length * width);
                    Console.WriteLine("");
                    Console.WriteLine("Your room's perimeter is " + (length * width) * 2);
                    Console.WriteLine("");
                    Console.WriteLine("The volume of your room is " + (length * height * width));
                    Console.WriteLine("");
                    do
                    {
                        
                        Console.WriteLine("You wanna do this again? answer 'y' or 'n' ");
                        input = Console.ReadLine();
                        Console.WriteLine("");
                        if (input == "n")
                        {
                            Console.WriteLine("Well have a good night!");
                            return;
                        }
                        else if (input == "y") 
                        {
                            Console.WriteLine("ok, cool.  enter a number");
                        }
                        else
                        {

                            Console.WriteLine("you've entered something else. please try again");
                        }
                    }
                    while (input != "y");
                }
                while (input != "y");
            }
            while (input=="y");
            

                




            



        }
    }
}
