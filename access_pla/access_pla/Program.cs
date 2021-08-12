using System;

namespace access_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            p1.Name = "山田太郎";
            p1.Age = 19;

            p2.SetNameAndAge("山田花子", 23);　// Personクラス内のメソッドにて値の設定なのでprivateでも変更設定可能
            p1.ShowNameandAge();
            p2.ShowNameandAge();　// 山田花子, 23歳が出力される

            //Personクラスのフィールドの値（name, age)を呼び出す方法

            Console.WriteLine($"名前: {p1.Name} 年齢: {p1.Age}"); //p1.nameとすることでプロパティ内の get が呼び出される
           
        }
    }
}
