using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
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
        Console.WriteLine("Manipulando lista e string.");
        Console.Write("Digite um nome: ");
        /* Operador de coalescência nula (??) para atribuir string.Empty (uma string vazia) 
        à variável nomeBusca caso Console.ReadLine() retorne null. 
        Isso garante que nomeBusca nunca seja null, eliminando o aviso CS8600.*/
        string nomeBusca = Console.ReadLine() ?? string.Empty;

        bool encontrado = false;
        foreach (string nome in nomes)
        {
            if (string.Equals(nome, nomeBusca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("O nome está na lista.");
        }
        else
        {
            Console.WriteLine("O nome não está na lista.");
        }

    }
}
