Filme filme = new Filme();

Console.Write("Título: ");
filme.titulo = Console.ReadLine();

Console.Write("Gênero: ");
filme.genero = Console.ReadLine();

Console.Write("Ano de Lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());


Console.Write("Classificação Indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();