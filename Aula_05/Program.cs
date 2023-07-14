Console.Write("Digite um nome: ");
string nome = Console.ReadLine();

if (string.IsNullOrEmpty(nome))
    {
        Console.WriteLine("O nome está vazio!");
    }
else
    {
        int quantidadeLetras = nome.Length;
        Console.WriteLine("A quantidade de letras no nome é: " + quantidadeLetras);
    }