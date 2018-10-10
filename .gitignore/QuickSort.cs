using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class QuickSort
    {
        int[] nRanNumbers = new int[] { 3, 9, 7, 6, 8, 1, 2, 4, 5 };

        public int[] Sort(int left, int right)
        {            
            if (left < right)
            {
                int pivot = Partition(nRanNumbers, left, right);

                if (pivot > 1)
                {
                    Sort(left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(pivot + 1, right);
                }
            }

            return nRanNumbers;
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }        
    }
}
