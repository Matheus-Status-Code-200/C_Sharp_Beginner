using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de Conversão de Entrada");
        Console.WriteLine("--------------------------------\n");

        Console.Write("Digite algo: ");
        string input = Console.ReadLine()?.Replace('.', ',');

        if (input != null && input.Length > 0)
        {
            bool possuiLetra = false;
            bool possuiNumero = false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    possuiLetra = true;
                }
                else if (char.IsDigit(c))
                {
                    possuiNumero = true;
                }
            }

            if (possuiLetra && possuiNumero)
            {
                Console.WriteLine("Letras e números não devem ser digitados juntos.");
            }
            else if (int.TryParse(input, out int numeroInteiro))
            {
                Console.WriteLine("Tipo: Inteiro");
                Console.WriteLine("Valor: " + numeroInteiro);
            }
            else if (float.TryParse(input, out float numeroFloat))
            {
                Console.WriteLine("Tipo: Ponto Flutuante");
                Console.WriteLine("Valor: " + numeroFloat);
            }
            else
            {
                Console.WriteLine("Você digitou um texto ou caractere especial.");
            }
        }
        else
        {
            Console.WriteLine("Nenhum valor digitado.");
        }
    }
}
