using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Consulta de Nomes por Posição");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Este programa permite consultar o nome correspondente a uma posição na lista de nomes.");

        List<string> nomes = new List<string>
        {
            "João",
            "Maria",
            "Pedro",
            "Ana",
            "Carlos",
            "Laura",
            "Fernando",
            "Lúcia",
            "Mariana",
            "Rafael"
        };

        Console.Write("Digite um número de 1 a " + nomes.Count + ": ");
        string input = Console.ReadLine() ?? string.Empty;

        /*string.IsNullOrEmpty(input) para garantir que a entrada do usuário não seja nula ou vazia antes de prosseguir*/
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Entrada inválida!");
        }
        else
        {
            if (int.TryParse(input, out int posicao))
            {
                if (posicao >= 1 && posicao <= nomes.Count)
                {
                    string nome = nomes[posicao - 1];
                    Console.WriteLine("O nome correspondente à posição " + posicao + " é: " + nome);
                }
                else
                {
                    Console.WriteLine("Posição inválida!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida!");
            }
        }

    }
}
