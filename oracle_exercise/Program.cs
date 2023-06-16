using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracle_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program using any language that prints out
            //the numbers 1 to 100(inclusive).If the number is
            //divisible by 3, print "Crackle" instead of the
            //number. If it's divisible by 5, print "Pop".
            //If it's divisible by both 3 and 5, print
            //"CracklePop".
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 & i % 3 == 0)
                {
                    Console.WriteLine("CraklePop");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Crakle");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Pop");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
