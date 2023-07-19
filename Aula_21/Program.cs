using System;

public class Program {

    public static void Main(string[] args) {

        // Cabeçalho
        Console.WriteLine("\nPrograma usando Dicionário.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Este programa cria um dicionário e adiciona alguns pares de chave-valor.");
        Console.WriteLine("Em seguida, imprime o dicionário na tela e faz uma busca por alguma chave.\n");

        // Cria um dicionário
        var dicionario = new Dictionary<string, string>();

        // Adiciona pares de chave-valor ao dicionário
        dicionario.Add("nome", "Matheus");
        dicionario.Add("sobrenome", "Silva");
        dicionario.Add("funcao", "DEV_");

        // Imprime o dicionário
        foreach (var par in dicionario) {
            Console.WriteLine("{0} = {1}", par.Key, par.Value);
        }

        // Solicita ao usuário para digitar uma chave
        Console.Write("Digite uma chave para procurar: ");
        string chave = Console.ReadLine()?? string.Empty;

        // Procura a chave no dicionário
        if (dicionario.ContainsKey(chave)) {
            Console.WriteLine("A chave '{0}' foi encontrada. O valor é '{1}'\n", chave, dicionario[chave]);
        } else {
            Console.WriteLine("A chave '{0}' não foi encontrada.\n", chave);
        }
    }
}
