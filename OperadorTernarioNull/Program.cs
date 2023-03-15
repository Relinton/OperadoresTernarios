using System;

namespace OperadorTernarioNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usando if else
            object a = null;
            object b = new object();
            object c;

            if (a != null)
                c = a;
            else
                c = b;

            //usando operador ternário
            object x = null;
            object y = new object();

            object z = (x != null) ? x : y;

            //usando o operador ?? 
            object i = null;
            object j = new object();

            object k = i ?? j;

            Console.WriteLine("Object k {0}", k);
            Console.ReadKey();
        }
    }
}
