using System;

public class Program {

    public static void Main(string[] args) {

        // Cabeçalho
        Console.WriteLine("\nPrograma usando Dicionário.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Este programa cria um dicionário e adiciona alguns pares de chave-valor. Em seguida, imprime o dicionário na tela.\n");

        // Cria um dicionário
        var dicionario = new Dictionary<string, string>();

        // Adiciona pares de chave-valor ao dicionário
        dicionario.Add("nome1", "Matheus");
        dicionario.Add("nome2", "Silva");
        dicionario.Add("nome3", "DEV_");

        // Imprime o dicionário
        foreach (var par in dicionario) {
            Console.WriteLine("{0} = {1}", par.Key, par.Value);
        }
        Console.WriteLine("Fim.\n");
    }
    
}
