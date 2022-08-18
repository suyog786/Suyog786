using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("The Even number is:  " + i);
                else
                    Console.WriteLine("No not found");
            }
        }
    }
}
