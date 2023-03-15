using System;

namespace OperadorCoalescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            //se x for null então retorna vazio
            //se x não for null então retorna;

            int y = x ?? -1;

            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
