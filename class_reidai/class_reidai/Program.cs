using System;

namespace class_reidai
{
    class Program
    {
        static void Main(string[] args)
        {
            Vecter2D v1 = new Vecter2D();
            v1.x = 1.0;
            v1.y = 1.0;
            Console.WriteLine($"初期値の表示：v1 = ({v1.x},{v1.y})");

            Vecter2D v2 = new Vecter2D();
            v2.x = 1.0;
            v2.y = -1.0;
            Console.WriteLine($"初期値の表示：v2 = ({v2.x},{v2.y})");

            // -- Vecter2D の Addメソッドを使用
            v1.Add(v2);
            Console.WriteLine($"v1 = ({v1.x},{v1.y})");

            // -- Vecter2D の Subメソッドを使用
            v1.Sub(v2);
            Console.WriteLine($"v1 = ({v1.x},{v1.y})");

            // -- Vecter2D の Mulメソッドを使用
            v1.Mul(2.0);
            Console.WriteLine($"v1 = ({v1.x},{v1.y}) ");

            // -- Vecter2D の DotProductメソッドを使用
            Console.WriteLine($"v1とv2の内積 = {v1.DotProduct(v2)}");
        }
    }
}
