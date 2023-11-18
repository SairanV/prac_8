using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            myDictionary.Add("One", 1);
            myDictionary["Two"] = 2;

            Console.WriteLine(myDictionary["One"]);  

            myDictionary.Remove("Two");
        }
    }
}
