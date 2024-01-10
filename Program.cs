using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are a male");
            }
            else

            { 
                Console.WriteLine("You're a Female");
            }

            bool isTall = true;
            if (isTall && isMale)
            {
                Console.WriteLine("You're both Tall and a Male");
            } else if (!isTall && isMale)
            {
                Console.WriteLine("You are a Male ,but not tall");
            }else
            {
                Console.WriteLine("You are either not tall or  male");
               
            }

            Console.Read();
        }
    }
}
