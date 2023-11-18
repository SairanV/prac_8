using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3;

namespace Ex_Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStorage storage = new DataStorage();

            storage[0] = 10;
            storage["John"] = 25;
            storage["J"] = 56;

            Console.WriteLine(storage[0]);
            Console.WriteLine(storage["John"]);
            Console.WriteLine(storage["J"]); 
        }
    }
}
