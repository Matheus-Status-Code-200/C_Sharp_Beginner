using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Conversão de Entrada");
        Console.WriteLine("--------------------------------\n");

        Console.Write("Digite algo: ");
        string input = Console.ReadLine()?? string.Empty;

        if (int.TryParse(input, out int numeroInteiro))
        {
            Console.WriteLine("Número inteiro digitado: " + numeroInteiro);
        }
        else if (float.TryParse(input, out float numeroFloat))
        {
            Console.WriteLine("Número de ponto flutuante digitado: " + numeroFloat);
        }
        else
        {
            Console.WriteLine("Você digitou um texto ou caractere especial.");
        }
    }
}
