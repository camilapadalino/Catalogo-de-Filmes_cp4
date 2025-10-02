namespace CatalogoFilmes.Models;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; }

    // Propriedade de navega��o: um g�nero pode ter v�rios filmes
    public List<Filme> Filmes { get; set; } = new List<Filme>();
}