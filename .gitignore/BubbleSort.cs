using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //Start from left, compare adjacent elements and move highest number to the right
    class BubbleSort
    {
        int[] nRanNumbers = new int[] { 3, 9, 7, 6, 8, 1, 2, 4, 5 };
        public int[] sort()
        {
            bool swapped;

            do
            {
                swapped = false;

               for (int i = 1; i < nRanNumbers.Length; i++)
                {
                    if (Compare(nRanNumbers[i - 1], nRanNumbers[i]) > 0)
                    {
                        Swap(i - 1, i,ref nRanNumbers);
                        swapped = true;
                    }
                    
                }

            } while (swapped != false);
            return nRanNumbers;
        }

        public int Compare(int nCompare, int nCompareTo)
        {
            if (nCompare > nCompareTo)
                return 1;

            return 0;
        }

        public void Swap(int i, int j, ref int[] nRanNumbers)
        {
            int temp = nRanNumbers[i];
            nRanNumbers[i] = nRanNumbers[j];
            nRanNumbers[j] = temp;
        }
    }
}
