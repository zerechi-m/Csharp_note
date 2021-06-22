using System;

namespace foreach_practice
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] array1 = { 1, 2, 3, 4, 5 };

                //配列から一つずつ値の取り出し

                foreach (int x in array1)
                {
                    Console.WriteLine(x);

                }
            }
        }
    }


