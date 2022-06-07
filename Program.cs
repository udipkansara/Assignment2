using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // variables
                int input = 0;
                int length;
                int width;

                // ask user to enter the length
                Console.WriteLine("Please enter the length of the rectangle: ");

                // validating input that user must have to enter greater than 0
                while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Oops! Please Enter integer value and also greater 0 :)");
                }

                // ask user to enter width
                Console.Write("Please enter the width of the rectangle: ");

                // validating input that user must have to enter greater than 0
                while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.Write("Oops! Please Enter integer value and also greater 0 :)");
                }

                do
                {
                    // Showing Menu items
                    input = ShowMenu();

                    // Initializing the Rectangle class
                    Rectangle rectangle = new Rectangle();
                    rectangle.SetLength(length);
                    rectangle.GetWidth();
                    rectangle.SetWidth(width);

                    // display length of rectangle
                    if (input == 1)
                    {
                        Console.Write("The length of rectangle is: ");
                        Console.WriteLine(rectangle.GetLength());
                    }

                    // Changing the length of rectangle
                    else if (input == 2)
                    {
                        Console.Write("Please enter the length of the rectangle: ");

                        // validating input that user must have to enter greater than 0
                        while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                        {
                            Console.WriteLine("Oops! Please Enter integer value and also greater 0 :)");
                        }
                    }

                    // display width of rectangle
                    else if (input == 3)
                    {
                        Console.Write("The width of rectangle is: ");
                        Console.WriteLine(rectangle.GetWidth());
                    }
                    else if (input == 4)
                    {
                        Console.Write("Please enter the width of the rectangle: ");

                        // validating input that user must have to enter greater than 0
                        while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                        {
                            Console.WriteLine("Oops! Please Enter integer value and also greater 0 :)");
                        }
                    }

                    // display the perimeter of rectangle
                    else if (input == 5)
                    {
                        Console.Write("The perimeter of rectangle is: ");
                        Console.WriteLine(rectangle.GetPerimeter());
                    }

                    // display the Area  of rectangle
                    else if (input == 6)
                    {
                        Console.Write("The area of rectangle is: ");
                        Console.WriteLine(rectangle.GetArea());
                    }

                    // Exiting user from applicaton
                    else if (input == 7)
                    {
                        Environment.Exit(0);
                    }
                }
                while (input < 7);
                Console.WriteLine("Please Enter a valid option!!");
                ShowMenu();
            }

            //Error handling
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int ShowMenu()
        {
            Console.Write("\n\n");
            Console.Write("---------------------------------\n");
            Console.Write("1. Get Rectangle Length\n");
            Console.Write("2. Change Rectangle Length\n");
            Console.Write("3. Get Rectangle Width\n");
            Console.Write("4. Change Rectangle Width\n");
            Console.Write("5. Get Rectangle Perimeter\n");
            Console.Write("6. Get Rectangle Area\n");
            Console.Write("7. Exit\n");
            Console.Write("---------------------------------\n");
            return int.Parse(Console.ReadLine());
        }
    }
        
}

