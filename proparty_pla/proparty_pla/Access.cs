using System;
namespace proparty_pla
{
    public class Access
    {
        //　読込オンリーのデータ
        private int data1 = 5;

        // 書込オンリーのデータ
        private int data2 = 1;

        // 値の表示
        public void ShowData()
        {
            Console.WriteLine($"data1 = {data1} : data2 = {data2}");
        }

        // data1 のプロパティ(読込のみ）
        public int Data1
        {
            get { return data1; }
        }

        // data2 のプロパティ(書込のみ)
        public int Data2
        {
            set { data2 = value; }
        }
    }
}
