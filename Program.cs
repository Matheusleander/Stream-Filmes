Filme filme = new Filme();

int opcao;

do
{
    Console.WriteLine("\n=====CATÁLOGO DE FILMES=====");
    Console.WriteLine("1 - Cadastrar Filme");
    Console.WriteLine("2 - Exibir Filme");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Título: ");
            filme.titulo = Console.ReadLine();

            Console.Write("Gênero: ");
            filme.genero = Console.ReadLine();

            Console.Write("Ano de Lançamento: ");
            filme.anoLancamento = Convert.ToInt32(Console.ReadLine());


            Console.Write("Classificação Indicativa: ");
            filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFilme cadastrado com sucesso!");
            break;
        case 2:
            if (string.IsNullOrEmpty(filme.titulo))
            {
                Console.WriteLine("\nNenhum filme cadastrado ainda :(");
            }
            else
            {
                filme.ExibirInformacoes();
            }
            break;
        case 0:
            Console.WriteLine("\nAtenção!!! Programa encerrado.");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }
} while (opcao != 0);





