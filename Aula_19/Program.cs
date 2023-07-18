using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nPrograma usando DateTime.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Este programa retorma o tempo de estudo em C#.\n");
        DateTime dataInicial = new DateTime(2023, 7, 13); // Definindo a data inicial

        DateTime dataAtual = DateTime.Now; // Obtendo a data atual

        TimeSpan tempoAprendizado = dataAtual - dataInicial; // Calculando o tempo de aprendizado

        int diasAprendizado = tempoAprendizado.Days; // Obtendo o número de dias de aprendizado

        Console.WriteLine("Data de inicio: " + dataInicial.ToString("dd/MM/yyyy"));
        Console.WriteLine("Dia atual: " + dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tempo de aprendizado em C#: " + diasAprendizado + " dias.");
    }
}
