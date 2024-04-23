using System;

namespace Func_Delegates
{
        public class Predicate_Del {
            public static bool myfunc(string mystring)
            {
                if (mystring.Length > 7)
                {
                    return true;
                }
                else {
                    return false;
                }
            }

            public void m1()
            {
                Predicate<string> val = myfunc;
                Console.WriteLine(val("Hello"));

            }
            public void m2()
            {
                Predicate<string> val = myfunc;
                Console.WriteLine(val("Heelooooo"));

            }
        
        }
    }

