using System;

namespace calculate_classroom
{
   
        class Program
        {
            static void Main(string[] args)
            {

                double perimiter = 0;
                double area = 0;
                double volume = 0;

                Console.Write("Please enter the Length: ");
                string length_entry = Console.ReadLine();
                double length = double.Parse(length_entry);

                Console.Write("Please enter the Width: ");
                string width_entry = Console.ReadLine();
                double width = double.Parse(width_entry);

                Console.Write("Please enter the Height: ");
                string height_entry = Console.ReadLine();
                double height = double.Parse(height_entry);

                perimiter = (length * 2) + (width * 2);
                area = (length * width);
                volume = (length * width * height);

                if (area <= 250)
                {
                    Console.WriteLine("This room is considered small");
                }
                else if (area > 250 || area < 650)
                {
                    Console.WriteLine("This room is considered medium");
                }
                else if (area >= 650)
                {
                    Console.WriteLine("This room is considered large");
                }

                Console.WriteLine($"Your Perimiter is: {perimiter:N2} feet");
                Console.WriteLine($"Your Area is: {area:N2} feet");
                Console.WriteLine($"Your Volume is: {volume:N2} feet");


            }
        }
    }
