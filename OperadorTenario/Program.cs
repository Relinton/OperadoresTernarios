using System;

namespace OperadorTenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Relinton", "Bruna", "Carla", "Daniel" };
            DateTime hora = DateTime.Now;
            Console.WriteLine("Agora: {0}", hora.ToLongDateString());

            //if(hora.Hour > 12)
            //    saudacao += "Boa tarde.";
            //else
            //    saudacao += "Bom dia.";

            string saudacao = hora.Hour > 12 ? "Boa tarde" : "Bom dia";

            Console.WriteLine("São {0} horas", hora.Hour);
            Console.WriteLine(saudacao);


            //--------------------------------------------------------//


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; Console.WriteLine(i), i++) { }

            //--------------------------------------------------------//

            int posicao = 0;
            foreach (var nome in nomes)
            {
                posicao++;
                Console.WriteLine("O nome na posição " + posicao + ": " + nome);
                if (posicao == 3)
                {
                    Console.WriteLine("O nome da posição 3 é: " + nome);
                }
            }

            Console.ReadKey();
        }
    }
}
