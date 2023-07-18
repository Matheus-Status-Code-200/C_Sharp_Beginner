using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Cadastro de Pessoa");
        Console.WriteLine("-----------------------------\n");
         Console.WriteLine("Usaremos tuplas....\n");

        // Solicitar e receber os dados do usuário
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()?? String.Empty;

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine()?? "0");

        Console.Write("Digite o país: ");
        string pais = Console.ReadLine()?? string.Empty;

        // Criar a tupla com os dados recebidos
        var pessoa = (nome, idade, pais);

        // Exibir os valores da tupla
        Console.WriteLine("\nDados da pessoa cadastrada:");
        Console.WriteLine("Nome: " + pessoa.nome);
        Console.WriteLine("Idade: " + pessoa.idade);
        Console.WriteLine("País: " + pessoa.pais);
    }
}
