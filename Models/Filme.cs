namespace CatalogoFilmes.Models;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int AnoLancamento { get; set; }
    public string Sinopse { get; set; }

    // Chave estrangeira para o Gênero
    public int GeneroId { get; set; }
    // Propriedade de navegação: um filme pertence a um gênero
    public Genero Genero { get; set; }
}