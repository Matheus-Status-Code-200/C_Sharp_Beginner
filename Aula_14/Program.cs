using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Consulta de manipulação de Lista.");
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Este programa permite adicionar, remove e consulta nomes em uma lista de nomes.");

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

        Console.WriteLine("\nOutras funcionalidades:");
        Console.WriteLine("-----------------------");

        Console.WriteLine("Verificar se a lista possui algum elemento: " + nomes.Any());

        Console.Write("Digite uma letra para buscar nomes que começam com essa letra: ");
        string letra = Console.ReadLine() ?? string.Empty;
        List<string> nomesComLetra = nomes.FindAll(x => x.StartsWith(letra, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Nomes que começam com a letra " + letra + ": " + string.Join(", ", nomesComLetra));

        nomes.Sort();
        Console.WriteLine("Lista de nomes ordenada em ordem alfabética crescente: " + string.Join(", ", nomes));

        nomes.Reverse();
        Console.WriteLine("Lista de nomes ordenada em ordem alfabética decrescente: " + string.Join(", ", nomes));

        Console.WriteLine("Digite a posição inicial e a quantidade de nomes a serem removidos (separados por vírgula):");
        string remocaoInput = Console.ReadLine() ?? string.Empty;
        if (remocaoInput.Contains(","))
        {
            string[] remocaoParams = remocaoInput.Split(',');
            if (remocaoParams.Length == 2 && int.TryParse(remocaoParams[0].Trim(), out int inicio) && int.TryParse(remocaoParams[1].Trim(), out int quantidade))
            {
                if (inicio >= 0 && inicio < nomes.Count && quantidade >= 0 && inicio + quantidade <= nomes.Count)
                {
                    nomes.RemoveRange(inicio, quantidade);
                    Console.WriteLine("Nomes removidos da lista: " + quantidade);
                    Console.WriteLine("Lista final: " + string.Join(", ", nomes));
                }
                else
                {
                    Console.WriteLine("Posição inicial ou quantidade inválida!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida!");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Você deve digitar dois valores separados por uma vírgula.");
        }

        Console.WriteLine("\nFim!");
    }
}
