using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_sample_delegate
{
    // デリゲートを定義
    public delegate int CalculateMethod(ref int x, int y);

    class method_for_delegate
    {
        // デリゲートに代入するためのメソッド（足し算）
        public int Add(ref int x, int y)
        {
            x = x + 1;
            return x + y;
        }

        // デリゲートに代入するためのメソッド（引き算）
        public int Sub(ref int x, int y)
        {
            x = x + 1;
            return x - y;
        }
    }
}
