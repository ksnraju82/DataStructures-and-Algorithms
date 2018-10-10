using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    // //Start from left, compare adjacent elements and INSERT the lesser element at right index
    class InsertionSort
    {
        int[] nRanNumbers = new int[] { 3, 9, 7, 6, 8, 1, 2, 4, 5 };

        public int[] Sort()
        {
            for (int i = 0; i < nRanNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (nRanNumbers[j - 1] > nRanNumbers[j])
                    {
                        int temp = nRanNumbers[j - 1];
                        nRanNumbers[j - 1] = nRanNumbers[j];
                        nRanNumbers[j] = temp;
                    }
                }
            }

            return nRanNumbers;
        }
    }
}
