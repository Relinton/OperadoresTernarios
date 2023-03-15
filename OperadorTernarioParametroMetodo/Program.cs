using System;

namespace OperadorTernarioParametroMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomePrimario = "Relinton";
            string nomeSecundario = "Pinheiro Franco";

            ExibirNome(nomePrimario.Length > 7 ? nomePrimario : nomeSecundario);
            Console.ReadKey();
        }

        private static void ExibirNome(string nome)
        {
            Console.WriteLine(nome);
        }
    }
}
