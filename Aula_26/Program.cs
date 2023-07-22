using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException("O número deve ser maior que zero.");

        if (n == 1 || n == 2)
            return 1;

        int prev1 = 1;
        int prev2 = 1;
        int result = 0;

        for (int i = 3; i <= n; i++)
        {
            result = prev1 + prev2;
            prev1 = prev2;
            prev2 = result;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Calculadora de Fibonacci");
        Console.Write("Digite o valor de 'n' para calcular o n-ésimo número da sequência de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        try
        {
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine($"O {n}-ésimo número da sequência de Fibonacci é: {fibonacciNumber}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
