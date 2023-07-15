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

        Console.WriteLine("Manipulando lista com Foreach:");
        foreach (string nome in nomes)
        {
            Console.WriteLine("Nome: " + nome);
        }

        Console.WriteLine($"Fim, sua lista possui {nomes.Count} nomes.");
        
    }
}
