using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = "Tip for the future: you already knew that this was called the console, because you used that word in the question. So looking for 'C# console read text' on Google would be a good way to answer this question yourself. (Note: this is not flaming, just some feedback for the next question)";
            //QuestionCount(strInput);
            //List<string> strWords = new list<string>();
            string[] strWords;
            strInput = strInput.ToLower();
            strInput = strInput.Replace(".", string.Empty);

            strWords = strInput.Split(null);
            int count = 0;
            foreach(string str in strWords)
            {
                if (str == "question")
                {
                    count++;
                }
            }

            //BubbleSort _bubblesort = new BubbleSort();
            //InsertionSort _bubblesort = new InsertionSort();
            //SelectionSort _bubblesort = new SelectionSort();
            QuickSort _quicksort = new QuickSort();
            int[] aftersort = _quicksort.Sort(0, 8);
            //int[] aftersort = _bubblesort.Sort();
            for(int i = 0; i < aftersort.Length; i++)
            {
                Console.WriteLine(aftersort[i]);                
            }
            Console.ReadLine();
        }

        //private void QuestionCount(string strInput)
        //{
        //    int count1 = 0;

        //    foreach(string str in strInput)
        //    {

        //    }
        //}
    }
}
