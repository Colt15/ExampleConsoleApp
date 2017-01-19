using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Exercises exercise = new Exercises(); //instantiate object from class

            Console.WriteLine(exercise.maxOfFive(4, 4, 6, 7, 8));

            string[] palinarray =
            {
            "radar",
            "dog",
            "cat",
            "levels",
            "dewed",
            };
            foreach (string palinvalue in palinarray)
            {
                Console.WriteLine("{0} = {1}", palinvalue, exercise.IsPalindrome(palinvalue));
            }

            string[] wordarray =
            {
                "Hello",
                "Fantastic",
                "Hat",
                "Punch",
            };
            foreach (string wordvalue in wordarray)
            {
                Console.WriteLine()
            };


            Console.ReadKey();
        }
    }
}
