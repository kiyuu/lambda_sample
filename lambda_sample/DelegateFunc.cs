using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_sample_delegate_func
{

    class method_for_delegate_func
    {
        // デリゲートに代入するためのメソッド（足し算）
        public int Add(int x, int y)
        {
            return x + y;
        }

        // デリゲートに代入するためのメソッド（引き算）
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}