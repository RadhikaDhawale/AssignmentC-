using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//wap to check number is divisible by 5 and 11 or not
namespace AssignmentC_
{
   internal class Divisibleby
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());
            if(n %  5 == 0)
            {
                Console.WriteLine("Enter number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Enter number is not divisible by 5 ");  
            }
            Console.ReadLine();
        }
    }
}
