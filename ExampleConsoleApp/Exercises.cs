using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConsoleApp
{
    class Exercises
    {
        public int maxOfFive(int number1, int number2, int number3, int number4, int number5)
        {
        List<int> myNumbers = new List<int>();
            myNumbers.Add(number1);
            myNumbers.Add(number2);
            myNumbers.Add(number3);
            myNumbers.Add(number4);
            myNumbers.Add(number5);

            return myNumbers.Max();
        }
        public bool IsPalindrome(string palinvalue)
        {
            int min = 0;
            int max = palinvalue.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = palinvalue[min];
                char b = palinvalue[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        public string findLongestWord(string wordvalue)
        {

        }
    }
}
