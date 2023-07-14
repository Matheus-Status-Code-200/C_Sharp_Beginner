Console.Write("Digite o primeiro valor inteiro: ");
int numeroInteiro1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor inteiro: ");
int numeroInteiro2 = int.Parse(Console.ReadLine());

Console.WriteLine("Soma de inteiros: " + (numeroInteiro1 + numeroInteiro2)+"\n");

Console.Write("Digite o primeiro valor decimal: ");
double numeroDecimal1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor decimal: ");
double numeroDecimal2 = double.Parse(Console.ReadLine());

Console.WriteLine("Multiplicação de decimais: " + (numeroDecimal1 * numeroDecimal2)+"\n");

Console.Write("Digite o primeiro nome: ");
string texto1 = Console.ReadLine();

Console.Write("Digite o sobrenome: ");
string texto2 = Console.ReadLine();

Console.WriteLine("Concatenação de strings: " + (texto1 + " " + texto2)+"\n");

Console.Write("Digite o valor booleano 1 (true/false): ");
bool condicao1 = bool.Parse(Console.ReadLine());

Console.Write("Digite o valor booleano 2 (true/false): ");
bool condicao2 = bool.Parse(Console.ReadLine());

Console.WriteLine("Operação booleana || : " + (condicao1 || condicao2));
Console.WriteLine("Operação booleana && : " + (condicao1 && condicao2)+"\n");

Console.Write("Digite um caractere: ");
char caractere = char.Parse(Console.ReadLine());
Console.WriteLine("Caractere: " + caractere);

DateTime dataHoraAtual = DateTime.Now;
Console.WriteLine("Data e hora atual: " + dataHoraAtual);
