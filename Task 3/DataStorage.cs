using System;
using System.Collections.Generic;

namespace Task_3
{
    public class DataStorage
    {
        private List<int> dataByIndex = new List<int>();
        private Dictionary<string, int> dataByName = new Dictionary<string, int>();

        public int this[int index]
        {
            get
            {
                EnsureIndexInRange(index);
                return dataByIndex[index];
            }
            set
            {
                EnsureIndexInRange(index);
                dataByIndex[index] = value;
            }
        }

        public int this[string name]
        {
            get { return dataByName[name]; }
            set { dataByName[name] = value; }
        }

        public int this[char firstLetterOfName]
        {
            get { return (int)firstLetterOfName; }
            set { dataByIndex.Add(value); }
        }

        private void EnsureIndexInRange(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс не может быть отрицательным");
            }

            while (index >= dataByIndex.Count)
            {
                dataByIndex.Add(0);
            }
        }
    }
}
