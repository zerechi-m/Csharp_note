using System;
namespace class_obj_pla
{
    public class Calc
    {
        //メソッドのオーバーロード：同じメソッド名【Add】を使用する

        // 二つの整数の和を求める
        public int Add(int a, int b)
        {
            return a + b;
        }

        // 三つの整数の和を求める
        public． int Add(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}