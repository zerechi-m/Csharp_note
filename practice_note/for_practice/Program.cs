using System;

namespace for_practice
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 0; i < 5; i++)  // i++ はインクリメント: 1 加算して値を返す
                                       // ++i はデクリメント: 　値を返してから 1 加算する
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            // length文との組み合わせ

            int[] num = { 1, 2, 3, 4, 5 };

            for (int i = 1; i <= num.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
