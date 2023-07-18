using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Consulta de Nomes por Posição");
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Este programa permite adicionar e consultar o nome correspondente a uma posição em uma lista de nomes.");

        List<string> nomes = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine() ?? string.Empty;
            nomes.Add(nome);
        }

        Console.Write("\nDigite uma posição de 1 a " + nomes.Count + ": ");
        string input = Console.ReadLine() ?? "0";

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

        Console.WriteLine("Fim!");
    }
}
