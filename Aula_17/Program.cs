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
        string nome1 = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o país: ");
        string pais1 = Console.ReadLine();

        // Adicionar a primeira pessoa à lista
        pessoas.Add((nome1, idade1, pais1));

        // Solicitar e receber os dados da segunda pessoa
        Console.WriteLine("\nCadastro da segunda pessoa:");
        Console.Write("Digite o nome: ");
        string nome2 = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o país: ");
        string pais2 = Console.ReadLine();

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
