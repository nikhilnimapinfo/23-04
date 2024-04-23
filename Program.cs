namespace Func_Delegates
{

    class Program
    {
        static void Main(string[] args)
        {
            FUNC_Del fUNC_Del = new FUNC_Del();
            fUNC_Del.method();


            Predicate_Del p = new Predicate_Del();
            p.m1();
            p.m2();

            Action_Delegate ac = new Action_Delegate();
            ac.main();

            

        }
    }
}
