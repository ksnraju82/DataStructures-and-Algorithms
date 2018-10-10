using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    // //Start from left, compare adjacent elements and INSERT the lesser element at right index
    class SelectionSort
    {
        int[] nRanNumbers = new int[] { 3, 9, 7, 6, 8, 1, 2, 4, 5 };

        public int[] Sort()
        {
            for (int i = 0; i < nRanNumbers.Length - 1; i++)
            {
                int minValue = nRanNumbers[i];
               for (int j = i + 1; j < nRanNumbers.Length; j++)
                {
                    if (minValue > nRanNumbers[j])
                    {
                        minValue = nRanNumbers[j];                        
                        nRanNumbers[j] = nRanNumbers[i];
                        nRanNumbers[i] = minValue;
                    }
                }  
            }

            return nRanNumbers;
        }
    }
}
