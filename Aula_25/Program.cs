using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nTry e catch.....");
        Console.WriteLine("-----------------------------\n");
         Console.WriteLine("Esse programa recebe uma entrada e analisa se é um numero ou letra\n");
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();

        try
        {
            double number = double.Parse(input);
            Console.WriteLine($"O número digitado em formato double é: {number:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Você digitou não digitou apenas numeros.\n");
        }
    }
}
