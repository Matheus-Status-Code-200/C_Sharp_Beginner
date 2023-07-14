using System;

class Program
{
    static void Main()
    {
        // Tipos inteiros
        int numeroInteiro = 10;
        int outroNumeroInteiro = 5;
        Console.WriteLine("Soma de inteiros: " + (numeroInteiro + outroNumeroInteiro));

        // Tipos decimais
        double numeroDecimal = 3.14;
        float outroNumeroDecimal = 2.5f;
        Console.WriteLine("Multiplicação de decimais: " + (numeroDecimal * outroNumeroDecimal));

        // Tipo string
        string texto1 = "Hello";
        string texto2 = "World";
        Console.WriteLine("Concatenação de strings: " + (texto1 + " " + texto2));

        // Tipo booleano
        bool condicao1 = true;
        bool condicao2 = false;
        Console.WriteLine("Operação booleana: " + (condicao1 || condicao2));

        // Tipo char
        char caractere = 'A';
        Console.WriteLine("Caractere: " + caractere);

        // Tipo DateTime
        DateTime dataHoraAtual = DateTime.Now;
        Console.WriteLine("Data e hora atual: " + dataHoraAtual);

        Console.ReadLine();
    }
}
