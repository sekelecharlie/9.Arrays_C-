using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of arrays
            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine(luckyNumbers.Length);
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine("The max is " + luckyNumbers.Max());

            string[] friends = new string[5];
            friends[0] = "Charlie";
            friends[1] = "Thato";
            friends[2] = Console.ReadLine();
            friends[3] = "Tetious";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);

            Console.ReadLine();

        }
    }
}
