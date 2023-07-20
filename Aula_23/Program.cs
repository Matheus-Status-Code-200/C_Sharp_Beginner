using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Dictionary<string, Dictionary<string, string>> cadastro = new Dictionary<string, Dictionary<string, string>>();
        
        Console.WriteLine("\nUsando dicionários dentro de dicionários e fazendo busca!");
        Console.WriteLine("--------------------------------\n");
        Console.WriteLine("Bem-vindo ao sistema de cadastro!");
        Console.WriteLine("--------------------------------\n");

        bool cadastroAtivo = true;

        while (cadastroAtivo)
        {
            Console.WriteLine("Deseja fazer um cadastro? (sim/não): ");
            Console.Write("S para (sim) e N para (não): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "n" || resposta == "nao")
            {
                cadastroAtivo = false;
            }
            else if (resposta == "sim" || resposta == "s")
            {
                Console.WriteLine("Deseja cadastrar um professor ou aluno? ");
                Console.Write("P para (professor) e A para (Aluno): ");
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
                    Console.WriteLine("Opção inválida! Digite P para 'professor' ou A 'aluno'.\n");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite 'S' ou 'N'.\n");
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

        bool buscaAtiva = true;
        while (buscaAtiva)
        {
            Console.WriteLine("Deseja fazer uma busca? (sim/não): ");
            Console.Write("S para (sim) e N para (não): ");
            string buscaResposta = Console.ReadLine().ToLower();

            if (buscaResposta == "n" || buscaResposta == "nao")
            {
                buscaAtiva = false;
            }
            else if (buscaResposta == "sim" || buscaResposta == "s")
            {
                Console.WriteLine("Deseja buscar por nome ou por tipo? ");
                Console.Write("N para (nome) e T para (tipo): ");
                string buscaPor = Console.ReadLine().ToLower();

                if (buscaPor == "nome" || buscaPor == "n")
                {
                    Console.Write("Digite o nome que deseja buscar: ");
                    string nomeBusca = Console.ReadLine();
                    Console.WriteLine("\nResultado da busca:\n");

                    foreach (var pessoa in cadastro)
                    {
                        if (pessoa.Value["nome"].ToLower().Contains(nomeBusca.ToLower()))
                        {
                            Console.WriteLine("Tipo: " + pessoa.Value["tipo"]);
                            Console.WriteLine("Nome: " + pessoa.Value["nome"]);
                            Console.WriteLine("Matéria: " + pessoa.Value["materia"]);
                            Console.WriteLine();
                        }
                    }
                }
                else if (buscaPor == "tipo" || buscaPor == "t")
                {
                    Console.WriteLine("Digite o tipo que deseja buscar (professor ou aluno): ");
                    Console.Write("P para (professor) e A para (aluno): ");
                    string tipoBusca = Console.ReadLine().ToLower();
                    if(tipoBusca == "p"){tipoBusca= "professor";
                    }else{tipoBusca = "aluno";}

                    Console.WriteLine("\nResultado da busca:\n");

                    foreach (var pessoa in cadastro)
                    {
                        if (pessoa.Value["tipo"].ToLower() == tipoBusca)
                        {
                            Console.WriteLine("Tipo: " + pessoa.Value["tipo"]);
                            Console.WriteLine("Nome: " + pessoa.Value["nome"]);
                            Console.WriteLine("Matéria: " + pessoa.Value["materia"]);
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite 'nome' ou 'tipo'.");
                }
            }
        }

        Console.WriteLine("Fim do programa.");
    }
}
