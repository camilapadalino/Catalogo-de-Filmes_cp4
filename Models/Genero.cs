namespace CatalogoFilmes.Models;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; }

    // Propriedade de navegação: um gênero pode ter vários filmes
    public List<Filme> Filmes { get; set; } = new List<Filme>();
}