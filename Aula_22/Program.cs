using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Dictionary<string, Dictionary<string, string>> cadastro = new Dictionary<string, Dictionary<string, string>>();

        Console.WriteLine("Bem-vindo ao sistema de cadastro!");
        Console.WriteLine("--------------------------------\n");

        bool cadastroAtivo = true;

        while (cadastroAtivo)
        {
            Console.WriteLine("Deseja fazer um cadastro?");
            Console.Write("S para (sim) e N para (não): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "n")
            {
                cadastroAtivo = false;
            }
            else if ( resposta == "s")
            {
                Console.Write("Deseja cadastrar um professor ou aluno? ");
                string tipo = Console.ReadLine().ToLower();

                if (tipo == "professor" || tipo == "p")
                {
                    Console.Write("Digite o nome do professor: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite a matéria que o professor leciona: ");
                    string materia = Console.ReadLine();

                    Dictionary<string, string> professor = new Dictionary<string, string>
                    {
                        {"nome", nome},
                        {"materia", materia},
                        {"tipo", "professor"}
                    };

                    cadastro.Add(nome, professor);
                    Console.WriteLine("Cadastro do professor realizado com sucesso!\n");
                }
                else if (tipo == "aluno" || tipo == "a")
                {
                    Console.Write("Digite o nome do aluno: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite a matéria em que o aluno está matriculado: ");
                    string materia = Console.ReadLine();

                    Dictionary<string, string> aluno = new Dictionary<string, string>
                    {
                        {"nome", nome},
                        {"materia", materia},
                        {"tipo", "aluno"}
                    };

                    cadastro.Add(nome, aluno);
                    Console.WriteLine("Cadastro do aluno realizado com sucesso!\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite 'professor' ou 'aluno'.\n");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite 'sim' ou 'não'.\n");
            }
        }

        if (cadastro.Count == 0)
        {
            Console.WriteLine("Cadastro vazio.");
        }
        else
        {
            Console.WriteLine("\nDados do cadastro:\n");

            foreach (var pessoa in cadastro)
            {
                Console.WriteLine("Tipo: " + pessoa.Value["tipo"]);
                Console.WriteLine("Nome: " + pessoa.Value["nome"]);
                Console.WriteLine("Matéria: " + pessoa.Value["materia"]);
                Console.WriteLine();
            }
        }
    }
}
