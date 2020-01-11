using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location;
            
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("In what state or country do you live? ");
            location = Console.ReadLine();

            DateTime today = DateTime.Today;

            Console.WriteLine($"My name is {name}, and I am from {location}. ");
            Console.WriteLine($"Today's date is {today.ToString("d")}. ");

            DateTime christmas = new DateTime(2020, 12, 25);
            double christmasCountdown = christmas.Subtract(DateTime.Today).TotalDays;

            Console.WriteLine($"There are {christmasCountdown} days until Christmas this year. ");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet.");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres.");

            Console.ReadLine();

        }
    }
}
