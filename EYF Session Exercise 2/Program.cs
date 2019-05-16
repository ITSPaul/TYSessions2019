using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYF_Session_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity.Track("Exercise 2 Finished");
            Console.WriteLine("I'm working as {0}", Activity.Name);

            // A Variable filled to hold the numbers we need
            int Count;
            Console.WriteLine("How Many numbers do you want to Add?");
            Count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Creating an array to hold {0} numbers", Count);

            // Create an array to hold the numbers
            int[] numbers = new int[Count];
            // Fill the array using a loop repeating for the number of times 
            // we want to read in a number
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Ill take number {0} please Rachel",i);
                numbers[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("It's a {0} {1}", numbers[i],Activity.Name);
            }
            // Loop over the array again to add all the numbers together updating the result each time
            int Result = 0;
            foreach (int number in numbers)
            {
                Console.Write("Adding number {0} to Result {1} ", number,Result);
                Result = Result + number;
                Console.WriteLine("Giving new Result {0}", Result);
            }
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();
        }
    }
}
