using System;

namespace proparty2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();

            p.SetNameAndAge("山田", 19);

            //年齢の変更
            p.Age = 32;

            //名前の変更
            //p.Name = "yamada";  // Person2クラスのNameプロパティのsetのアクセス修飾子がprivate

            Console.WriteLine($"{p.Name}");
        }
    }
}
