using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a console application that has a method that takes in 2
//integers as a parameter and returns the smallest of the two integers

namespace ConsoleApplication1_Redo
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1;
            int integer2;
            int min;

            Console.WriteLine("Please Enter the first Integer: " + '\n');
            integer1 = int.Parse(Console.ReadLine());

            Console.WriteLine('\n' + "Please Enter the second Integer: " + '\n');
            integer2 = int.Parse(Console.ReadLine());

            Console.WriteLine('\n' + "The new integers you entered were: " + integer1 + " and " + integer2);
            //Console.ReadLine();

            min = Math.Min(integer1, integer2);

            Console.WriteLine('\n' + "The smallest integer is: " + min + '\n');

            Console.ReadLine();
        }
    }
}
