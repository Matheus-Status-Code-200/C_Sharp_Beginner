using System;

class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("\nBem-vindo à calculadora!");
        Console.WriteLine("-----------------------------\n");
        Console.WriteLine("Usaremos classes separadas.\n");

        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Calculator calculator = new Calculator();
        int result = calculator.Add(num1, num2);

        Console.WriteLine($"Resultado da soma: {result}\n");
    }
}
