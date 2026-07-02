using System;
using System.Collections.Generic;

namespace StreamFilmes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Filme> listaFilmes = new List<Filme>();
            int opcao;

            do
            {
                Console.WriteLine("\n===== CATÁLOGO DE FILMES =====");
                Console.WriteLine("1 - Cadastrar Filme");
                Console.WriteLine("2 - Exibir Todos os Filmes");
                Console.WriteLine("3 - Buscar Filme por Título");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Filme novoFilme = new Filme();

                        Console.Write("Título: ");
                        novoFilme.titulo = Console.ReadLine();

                        Console.Write("Gênero: ");
                        novoFilme.genero = Console.ReadLine();

                        // Validação do ano
                        int ano;
                        do
                        {
                            Console.Write("Ano de lançamento (1888 até 2026): ");
                            ano = Convert.ToInt32(Console.ReadLine());

                            if (ano < 1888 || ano > 2026)
                            {
                                Console.WriteLine("Ano inválido! Digite um ano real entre 1888 e 2026.");
                            }

                        } while (ano < 1888 || ano > 2026);

                        novoFilme.anoLancamento = ano;

                        Console.Write("Classificação indicativa: ");
                        novoFilme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

                        listaFilmes.Add(novoFilme);

                        Console.WriteLine("\nFilme cadastrado com sucesso!");
                        break;

                    case 2:

                        if (listaFilmes.Count == 0)
                        {
                            Console.WriteLine("\nNenhum filme cadastrado ainda.");
                        }
                        else
                        {
                            foreach (var filme in listaFilmes)
                            {
                                filme.ExibirInformacoes();
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Digite o título para buscar: ");
                        string termoBusca = Console.ReadLine();

                        bool encontrado = false;

                        foreach (var filme in listaFilmes)
                        {
                            if (filme.titulo.ToLower().Contains(termoBusca.ToLower()))
                            {
                                filme.ExibirInformacoes();
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("\nNenhum filme encontrado com esse termo.");
                        }
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 0:

                        Console.WriteLine("\nPrograma encerrado.");
                        break;

                    default:

                        Console.WriteLine("\nOpção inválida.");
                        break;
                }

            } while (opcao != 0);
        }
    }
}