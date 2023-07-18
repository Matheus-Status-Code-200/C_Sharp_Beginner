using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Cadastro de Pessoas");
        Console.WriteLine("-----------------------------\n");

        Console.WriteLine("Utilizando Listas e Tuplas juntas.\n");

        // Criar uma lista de tuplas para armazenar as pessoas
        List<(string nome, int idade, string pais)> pessoas = new List<(string, int, string)>();

        // Solicitar e receber os dados da primeira pessoa
        Console.WriteLine("Cadastro da primeira pessoa:");
        Console.Write("Digite o nome: ");
        string nome1;
        do
        {
            nome1 = Console.ReadLine();
            if (string.IsNullOrEmpty(nome1))
            {
                Console.Write("Nome inválido! Digite novamente: ");
            }
        } while (string.IsNullOrEmpty(nome1));

        Console.Write("Digite a idade: ");
        int idade1;
        while (!int.TryParse(Console.ReadLine(), out idade1) || idade1 <= 0)
        {
            Console.Write("Idade inválida! Digite novamente: ");
        }

        Console.Write("Digite o país: ");
        string pais1;
        do
        {
            pais1 = Console.ReadLine();
            if (string.IsNullOrEmpty(pais1))
            {
                Console.Write("País inválido! Digite novamente: ");
            }
        } while (string.IsNullOrEmpty(pais1));

        // Adicionar a primeira pessoa à lista
        pessoas.Add((nome1, idade1, pais1));

        // Solicitar e receber os dados da segunda pessoa
        Console.WriteLine("\nCadastro da segunda pessoa:");
        Console.Write("Digite o nome: ");
        string nome2;
        do
        {
            nome2 = Console.ReadLine();
            if (string.IsNullOrEmpty(nome2))
            {
                Console.Write("Nome inválido! Digite novamente: ");
            }
        } while (string.IsNullOrEmpty(nome2));

        Console.Write("Digite a idade: ");
        int idade2;
        while (!int.TryParse(Console.ReadLine(), out idade2) || idade2 <= 0)
        {
            Console.Write("Idade inválida! Digite novamente: ");
        }

        Console.Write("Digite o país: ");
        string pais2;
        do
        {
            pais2 = Console.ReadLine();
            if (string.IsNullOrEmpty(pais2))
            {
                Console.Write("País inválido! Digite novamente: ");
            }
        } while (string.IsNullOrEmpty(pais2));

        // Adicionar a segunda pessoa à lista
        pessoas.Add((nome2, idade2, pais2));

        // Exibir os dados das pessoas cadastradas
        Console.WriteLine("\nDados das pessoas cadastradas:");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("País: " + pessoa.pais);
            Console.WriteLine();
        }
    }
}
