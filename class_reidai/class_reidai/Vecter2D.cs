using System;
namespace class_reidai
{
    public class Vecter2D
    {
        //クラスのフィールド変数
        public double x = 0.0;
        public double y = 0.0;

        // 他のベクトルの値を足すメソッド
        public void Add(Vecter2D v)  //実引数は v2 とインスタンスを渡しているので 型はクラス名になる
        {
            this.x += v.x;
            this.y += v.y;
        }

        // 他のベクトルの値をひくメソッド
        public void Sub(Vecter2D v)
        {
            this.x -= v.x;
            this.y -= v.y;
        }

        // ベクトルのスカラー倍を行うメソッド
        public void Mul(double k)
        {
            this.x *= k;
            this.y *= k;
        }

        // 他のベクトルの内積を計算するメソッド
        public double DotProduct( Vecter2D v)
        {
            return x * v.x + y * v.y;
            
        }
    }
}
