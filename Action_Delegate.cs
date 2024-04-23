using System;

namespace Func_Delegates
{
    public class Action_Delegate {
        public static void Substraction(int x,int y)
        {
            Console.WriteLine("Substractionn : " +(x-y));
        }
        public static void Addition(int x, int y)
        {
            Console.WriteLine("Additionn :" +(x+y));
        }
        public void main()
        {
            Action<int, int> val = Substraction;
            val(20,5);

            Action<int, int> val1 = Addition;
            val1(30,40);

        }
    }
}
