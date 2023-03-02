using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();

            string vogais = "aeiouAEIOU";
            string consoantesEncontradas = " ";

            for (int i = 0; i < str.Length; i++)
            {
                if (!vogais.Contains(str[i].ToString()))
                {
                    consoantesEncontradas += str[i];
                }
            }

            Console.WriteLine("Consoantes encontradas na string: " + consoantesEncontradas);
        }
    }
}