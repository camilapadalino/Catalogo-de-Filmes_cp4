namespace CatalogoFilmes.Models;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int AnoLancamento { get; set; }
    public string Sinopse { get; set; }

    // Chave estrangeira para o G�nero
    public int GeneroId { get; set; }
    // Propriedade de navega��o: um filme pertence a um g�nero
    public Genero Genero { get; set; }
}