using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYSessions2019
{
    class Program
    {
         
    static void Main(string[] args)
        {
            Activity.Track("Exercise 1 Adding two numbers together");
            Console.WriteLine("This is the Program of {0}", Activity.Name);
            int num1, num2, result;
            Console.WriteLine("Enter First Number followed by return");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", num1);
            Console.WriteLine("Enter Second Number followed by return");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", num2);
            result = num1 + num2;
            Console.WriteLine("The result of {0} + {1} is {2}", num1, num2, result);
            Console.WriteLine("Press any Key to exit");
            Console.ReadKey();

        }
    }
}
