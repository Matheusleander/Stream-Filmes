public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n=== Filme Cadastrado ===");
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Ano de lançamento: " + anoLancamento);
        Console.WriteLine("Classificação: " + classificacaoIndicativa);
    }
}