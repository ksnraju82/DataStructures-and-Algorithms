using System;
using System.Collections.Generic;
using BinaryTree;

namespace DataStructures
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] nRanNumbers = new int[] { 3, 9, 7, 6, 8, 1, 2, 4, 5 };
            BinaryTree<int> tree = new BinaryTree<int>();
            
            foreach(int x in nRanNumbers)
            {
                tree.Add(x);
                Console.WriteLine(x);
            }           

            
            Console.ReadLine();
        }
    }
}
