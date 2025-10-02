using CatalogoFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoFilmes.Data;

public class CatalogoContext : DbContext
{
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Genero> Generos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Cria um arquivo de banco de dados chamado "catalogo.db" na pasta do projeto
        optionsBuilder.UseSqlite("Data Source=catalogo.db");
    }
}