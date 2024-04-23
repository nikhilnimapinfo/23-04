using System;


namespace Func_Delegates
{
    public class FUNC_Del {
        public static int m1(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public void method()
        {
            Func<int, int, int, int, int> val = m1;
            Console.WriteLine(val(10, 20, 30, 40));
        }


    }
}
