using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_sample_delegate_Func
{

    class method_for_delegate_Func
    {
        // デリゲートに代入するためのメソッド（足し算）
        public int Add(int x, int y)
        {
            x = x + 1;
            return x + y;
        }

        // デリゲートに代入するためのメソッド（引き算）
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}