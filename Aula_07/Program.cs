using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Manipulando lista com For: \n");
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

        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"Nome na posição {i}: " + nomes[i]);
        }
        Console.WriteLine($"Fim, sua lista possui {nomes.Count} nomes.");
      
    }
}
