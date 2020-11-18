using System;
using System.Linq;

namespace GitYulia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[5];
            arrayOfNumbers[0] = 13;
            arrayOfNumbers[1] = 22;
            arrayOfNumbers[2] = 13;
            arrayOfNumbers[3] = 22;
            arrayOfNumbers[4] = 13;
            arrayOfNumbers[5] = 22;

            Console.WriteLine("Check if you pick a lucky number");
            int myNr = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i <arrayOfNumbers.Length; i++)
            {
                if (myNr == arrayOfNumbers[i])
                {
                    Console.WriteLine("Winner wineer");
                    break;
                }
                else
                {
                    Console.WriteLine("Not this time");
                }
            }
            Console.WriteLine(arrayOfNumbers.Contains(3));
    }
}
