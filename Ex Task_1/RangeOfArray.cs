using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task_1
{
    public class RangeOfArray
    {
        private int lowerBound;
        private int upperBound;
        private int[] array;

        public RangeOfArray(int lower, int upper)
        {
            lowerBound = lower;
            upperBound = upper;
            array = new int[upper - lower + 1];
        }

        public int this[int index]
        {
            get
            {
                if (IsIndexValid(index))
                    return array[index - lowerBound];
                else
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона");
            }
            set
            {
                if (IsIndexValid(index))
                    array[index - lowerBound] = value;
                else
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона");
            }
        }

        private bool IsIndexValid(int index)
        {
            return index >= lowerBound && index <= upperBound;
        }
    }
}
