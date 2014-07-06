using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a console application that compares 2 Book objects by their Price. 
//Return 0 if the prices are the same, 1 if the first book is more expensive 
//than the second and -1 if the first book is cheaper than the second book.

namespace ConsoleApplication2_Redo
{
    class Program
    {
        static void Main(string[] args)
        {
            string book1;
            string book2;
            decimal price1;
            decimal price2;

            //Enter First Book's Information
            Console.WriteLine("Please Enter your first book: " + '\n');
            book1 = Console.ReadLine();

            Console.WriteLine('\n' + "Please Enter your first book's price: " + '\n');
            price1 = decimal.Parse(Console.ReadLine());

            //Enter Second Book's Information
            Console.WriteLine('\n' + "Please Enter your second book: " + '\n');
            book2 = Console.ReadLine();

            Console.WriteLine('\n' + "Please Enter your second book's price: " + '\n');
            price2 = decimal.Parse(Console.ReadLine());

            //Print out First and Second Book's Information to Confirm Choices

            Console.WriteLine('\n' + "First book's name: " + book1 + '\n' + "First book's price: " + price1);
            //Console.ReadLine();

            Console.WriteLine('\n' + "Second book's name: " + book2 + '\n' + "Second book's price: " + price2);

            //Return 0 if the prices are the same, 1 if the first book is more expensive 
            //than the second and -1 if the first book is cheaper than the second book.

            if (price1 == price2)
            {
                Console.WriteLine('\n' + "The 2 book prices are the same: Returning 0");
            }
            else if (price1 > price2)
            {
                Console.WriteLine('\n' + "The first book is more expensive than the second book: Returning 1");
            }
            else //if (price1 < price2)
            {
                Console.WriteLine('\n' + "The second book is more expensive than the first book: Returning -1");
            }

            Console.ReadLine();           
        }
    }
}
