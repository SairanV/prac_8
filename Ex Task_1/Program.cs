using System;

namespace Ex_Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            RangeOfArray array1 = new RangeOfArray(6, 10);
            RangeOfArray array2 = new RangeOfArray(-9, 15);

            array1[6] = 10;
            array1[7] = 20;

            array2[-9] = 5;
            array2[0] = 15;

            Console.WriteLine(array1[6]);   
            Console.WriteLine(array2[-9]); 
        }
    }
}
