using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms.Interface;

namespace SortingAlgorithms
{
    class Bubble : ISort
    {
        public int n { get; set; }
        public int[] arr { get; set; }

        public Bubble(int num)
        {
            n = num;
            arr = new int[n];
        }

        public void SetValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Compare();
        }

        public void Compare()
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] >= arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
