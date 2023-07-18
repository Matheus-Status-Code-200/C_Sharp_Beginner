using System;

class Program
{
    static void Main()
    {
        // Cabeçalho explicativo
        Console.WriteLine("Manipulação de Tuplas em C#");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Este programa demonstra como criar, acessar e manipular tuplas em C#.\n");
// Criando uma tupla
        var pessoa = ("João", 25, "Brasil");

        // Acessando elementos da tupla
        string nome = pessoa.Item1;
        int idade = pessoa.Item2;
        string pais = pessoa.Item3;

        // Exibindo os valores da tupla
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("País: " + pais);

        // Alterando elementos da tupla
        pessoa.Item1 = "Maria";
        pessoa.Item2 = 30;
        pessoa.Item3 = "EUA";

        // Exibindo os valores atualizados da tupla
        Console.WriteLine("\nValores atualizados da tupla:");
        Console.WriteLine("Nome: " + pessoa.Item1);
        Console.WriteLine("Idade: " + pessoa.Item2);
        Console.WriteLine("País: " + pessoa.Item3);

        // Declarando uma tupla com tipos de dados nomeados
        (string nome, int idade, string pais) pessoa2 = ("Carlos", 40, "Canadá");

        // Acessando elementos da tupla com tipos de dados nomeados
        string nome2 = pessoa2.nome;
        int idade2 = pessoa2.idade;
        string pais2 = pessoa2.pais;

        // Exibindo os valores da segunda tupla
        Console.WriteLine("\nNome: " + nome2);
        Console.WriteLine("Idade: " + idade2);
        Console.WriteLine("País: " + pais2);

        // Desconstruindo uma tupla
        var (nomeDesconstruido, idadeDesconstruida, paisDesconstruido) = pessoa2;

        // Exibindo os valores desconstruídos da tupla
        Console.WriteLine("\nDesconstruindo a tupla:");
        Console.WriteLine("Nome: " + nomeDesconstruido);
        Console.WriteLine("Idade: " + idadeDesconstruida);
        Console.WriteLine("País: " + paisDesconstruido);
    }
}
