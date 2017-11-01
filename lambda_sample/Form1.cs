using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lambda_sample_delegate;
using lambda_sample_inline_method;
using lambda_sample_delegate_func;

namespace lambda_sample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.button1.Click += new System.EventHandler(this.clickCommon);
            this.button2.Click += new System.EventHandler(this.clickCommon);
            this.button3.Click += new System.EventHandler(this.clickCommon);
            this.button4.Click += new System.EventHandler(this.clickCommon);
            this.button5.Click += new System.EventHandler(this.clickCommon);
        }

        private void clickCommon(object sender, EventArgs e)
        {
            LblGuide.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Delegateで渡す関数のインスタンスを作成
            var main = new method_for_delegate();

            // Delegateに代入
            lambda_sample_delegate.CalculateMethod calc = new lambda_sample_delegate.CalculateMethod(main.Add);
            LblAddAnswer.Text = calc(10, 20).ToString();

            // Delegateに代入
            calc = new lambda_sample_delegate.CalculateMethod(main.Sub);
            LblSubAnswer.Text = calc(10, 20).ToString();

            List<string> recs = new List<string>() {
                string.Empty
                ,"delegate int CalculateMethod(int x, int y);"
                , string.Empty
                , "class method_for_delegate"
                , "{"
                , "    // デリゲートに代入するためのメソッド（足し算）"
                , "    public int Add(int x, int y)"
                , "    {"
                , "        return x + y;"
                , "    }"
                , string.Empty
                , "    // デリゲートに代入するためのメソッド（引き算）"
                , "    public int Sub(int x, int y)"
                , "    {"
                , "        return x - y;"
                , "    }"
                , "}"
                , string.Empty
                , "(使用する側)"
                , string.Empty
                , "// Delegateで渡す関数のインスタンスを作成"
                , "var main = new method_for_delegate();"
                , string.Empty
                , "// Delegateに代入"
                , "CalculateMethod calc = new CalculateMethod(main.Add);"
                , "LblAddAnswer.Text = calc(10, 20).ToString();"
                , string.Empty
                , "// Delegateに代入"
                , "calc = new CalculateMethod(main.Sub);"
                , "LblSubAnswer.Text = calc(10, 20).ToString();"
            };
            IEnumerable<string> list = recs.Where(s => true);
            label1.Text = LineInput(list);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // 匿名関数を使用してそのままDelegateに代入
            lambda_sample_inline_method.CalculateMethod calc = delegate (int x, int y) { return x + y; };
            LblAddAnswer.Text = calc(10, 20).ToString();

            // 匿名関数を使用してそのままDelegateに代入
            calc = delegate (int x, int y) { return x - y; };
            LblSubAnswer.Text = calc(10, 20).ToString();

            List<string> recs = new List<string>() {
                string.Empty,"delegate int CalculateMethod(int x, int y);", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty
                , string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "(使用する側)", string.Empty, string.Empty
                , string.Empty
                , string.Empty
                , "// 匿名関数を使用してそのままDelegateに代入"
                , "lambda_sample_inline_method.CalculateMethod calc = delegate (int x, int y) { return x + y; };"
                , "LblAddAnswer.Text = calc(10, 20).ToString();"
                , string.Empty
                , "// 匿名関数を使用してそのままDelegateに代入"
                , "calc = delegate (int x, int y) { return x - y; };"
                , "LblSubAnswer.Text = calc(10, 20).ToString();"
            };
            IEnumerable<string> list = recs.Where(s => true);
            label1.Text = LineInput(list);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // 匿名関数を使用して定義済み型であるFuncに代入
            Func<int, int, int> calc = delegate (int x, int y) { return x + y; };
            LblAddAnswer.Text = calc(10, 20).ToString();

            // 定義済み型であるFuncに代入
            calc = delegate (int x, int y) { return x - y; };
            LblSubAnswer.Text = calc(10, 20).ToString();

            List<string> recs = new List<string>() {
                string.Empty,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty
                , string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "(使用する側)", string.Empty
                , string.Empty
                , string.Empty
                , string.Empty
                , "// 匿名関数を使用して定義済み型であるFuncに代入"
                , "Func<int, int, int> calc = delegate (int x, int y) { return x + y; };"
                , "LblAddAnswer.Text = calc(10, 20).ToString();"
                , string.Empty
                , "// 匿名関数を使用して定義済み型であるFuncに代入"
                , "calc = delegate (int x, int y) { return x - y; };"
                , "LblSubAnswer.Text = calc(10, 20).ToString();"
            };
            IEnumerable<string> list = recs.Where(s => true);
            label1.Text = LineInput(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // ラムダ式を使用して定義済み型であるFuncに代入
            Func<int, int, int> calc = (x, y) => { return x + y; };
            LblAddAnswer.Text = calc(10, 20).ToString();

            // ラムダ式を使用して定義済み型であるFuncに代入
            calc = (x, y) => { return x - y; };
            LblSubAnswer.Text = calc(10, 20).ToString();

            List<string> recs = new List<string>() {
                string.Empty,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty
                , string.Empty,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "(使用する側)", string.Empty
                , string.Empty
                , string.Empty
                , string.Empty
                , "// ラムダ式を使用して定義済み型であるFuncに代入"
                , "Func<int, int, int> calc =(x, y)=> { return x + y; };"
                , "LblAddAnswer.Text = calc(10, 20).ToString();"
                , string.Empty
                , "// ラムダ式を使用して定義済み型であるFuncに代入"
                , "calc = (x, y) => { return x - y; };"
                , "LblSubAnswer.Text = calc(10, 20).ToString();"
            };
            IEnumerable<string> list = recs.Where(s => true);
            label1.Text = LineInput(list);

        }
        public string LineInput<T>(IEnumerable<T> array)
        {
            return string.Join("\r\n       ", array);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Delegateで渡す関数のインスタンスを作成
            var main = new method_for_delegate_func();

            // 定義済み型であるFuncに代入
            Func<int, int, int> calc = main.Add;
            LblAddAnswer.Text = calc(10, 20).ToString();

            // 定義済み型であるFuncに代入
            calc = main.Sub;
            LblSubAnswer.Text = calc(10, 20).ToString();

            List<string> recs = new List<string>() {
                string.Empty
                , string.Empty
                , string.Empty
                , "class method_for_delegate_func"
                , "{"
                , "    // デリゲートに代入するためのメソッド（足し算）"
                , "    public int Add(int x, int y)"
                , "    {"
                , "        return x + y;"
                , "    }"
                , string.Empty
                , "    // デリゲートに代入するためのメソッド（引き算）"
                , "    public int Sub(int x, int y)"
                , "    {"
                , "        return x - y;"
                , "    }"
                , "}"
                , string.Empty
                , "(使用する側)"
                , string.Empty
                , string.Empty
                , string.Empty
                , string.Empty
                , "// 定義済み型であるFuncに代入"
                , "Func<int, int, int> calc = main.Add;"
                , "LblAddAnswer.Text = calc(10, 20).ToString();"
                , string.Empty
                , "// 定義済み型であるFuncに代入"
                , "calc = main.Sub;"
                , "LblSubAnswer.Text = calc(10, 20).ToString();"
            };
            IEnumerable<string> list = recs.Where(s => true);
            label1.Text = LineInput(list);

        }
    }

}
