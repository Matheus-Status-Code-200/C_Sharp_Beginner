using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um nome: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O nome está vazio!");
            Console.WriteLine("Fim do programa.");
                return;
        }
        else
        {
            Console.Write($"Digite a posição do nome de 1 a {nome.Length} que deseja obter a letra: ");
            int posicao = int.Parse(Console.ReadLine());

            if (posicao >= 1 && posicao <= nome.Length)
            {
                char letra = nome[posicao - 1];
                Console.WriteLine("A letra na posição " + posicao + " é: " + letra);
                Console.WriteLine("Fim do programa.");
                return;
            }
            else
            {
                Console.WriteLine("Posição inválida!");
                Console.WriteLine("Fim do programa.");
                return;

            }
        }

        Console.ReadLine();
    }
}

