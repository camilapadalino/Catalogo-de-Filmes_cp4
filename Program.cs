using CatalogoFilmes.Data;
using CatalogoFilmes.Models;
using Microsoft.EntityFrameworkCore;

// Cria uma instância do nosso contexto do banco de dados
using var db = new CatalogoContext();

Console.WriteLine("=====================================");
Console.WriteLine("Bem-vindo ao Catálogo de Filmes!");
Console.WriteLine("=====================================\n");

// Garante que o banco de dados seja criado e populado na primeira execução
InicializarBancoDeDados();

// Loop principal do menu
while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Adicionar Filme");
    Console.WriteLine("2. Listar Filmes");
    Console.WriteLine("3. Atualizar Filme");
    Console.WriteLine("4. Deletar Filme");
    Console.WriteLine("5. Sair");
    Console.Write("Opção: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            AdicionarFilme();
            break;
        case "2":
            ListarFilmes();
            break;
        case "3":
            AtualizarFilme();
            break;
        case "4":
            DeletarFilme();
            break;
        case "5":
            Console.WriteLine("Até mais!");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

void InicializarBancoDeDados()
{
    // Se não houver nenhum gênero, adiciona alguns gêneros padrão
    if (!db.Generos.Any())
    {
        Console.WriteLine("Populando o banco de dados com gêneros iniciais...");
        db.Generos.AddRange(
            new Genero { Nome = "Ação" },
            new Genero { Nome = "Comédia" },
            new Genero { Nome = "Ficção Científica" },
            new Genero { Nome = "Drama" }
        );
        db.SaveChanges();
    }
}

void AdicionarFilme()
{
    Console.Write("Título do Filme: ");
    var titulo = Console.ReadLine();

    Console.Write("Ano de Lançamento: ");
    var ano = int.Parse(Console.ReadLine());

    Console.WriteLine("Escolha o Gênero:");
    var generos = db.Generos.ToList();
    for (int i = 0; i < generos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {generos[i].Nome}");
    }
    Console.Write("Número do Gênero: ");
    var generoIndex = int.Parse(Console.ReadLine()) - 1;
    var generoSelecionado = generos[generoIndex];

    var novoFilme = new Filme
    {
        Titulo = titulo,
        AnoLancamento = ano,
        Sinopse = "Sinopse a ser preenchida", // Simplicidade
        Genero = generoSelecionado
    };

    db.Filmes.Add(novoFilme);
    db.SaveChanges();

    Console.WriteLine($"\nFilme '{titulo}' adicionado com sucesso!");
}

void ListarFilmes()
{
    Console.WriteLine("\n--- Lista de Filmes no Catálogo ---");
    var filmes = db.Filmes
        .Include(f => f.Genero) // Inclui o Gênero na consulta
        .ToList();

    if (!filmes.Any())
    {
        Console.WriteLine("Nenhum filme cadastrado.");
        return;
    }

    foreach (var filme in filmes)
    {
        Console.WriteLine($"ID: {filme.Id} | Título: {filme.Titulo} ({filme.AnoLancamento}) | Gênero: {filme.Genero.Nome}");
    }
    Console.WriteLine("------------------------------------");
}

void AtualizarFilme()
{
    ListarFilmes();
    Console.Write("\nDigite o ID do filme que deseja atualizar: ");
    var id = int.Parse(Console.ReadLine());

    var filme = db.Filmes.Find(id);
    if (filme == null)
    {
        Console.WriteLine("Filme não encontrado.");
        return;
    }

    Console.Write($"Novo título para '{filme.Titulo}': ");
    var novoTitulo = Console.ReadLine();
    if (!string.IsNullOrEmpty(novoTitulo))
    {
        filme.Titulo = novoTitulo;
    }

    Console.Write($"Novo ano para '{filme.AnoLancamento}': ");
    var novoAnoStr = Console.ReadLine();
    if (!string.IsNullOrEmpty(novoAnoStr))
    {
        filme.AnoLancamento = int.Parse(novoAnoStr);
    }

    db.SaveChanges();
    Console.WriteLine("\nFilme atualizado com sucesso!");
}

void DeletarFilme()
{
    ListarFilmes();
    Console.Write("\nDigite o ID do filme que deseja deletar: ");
    var id = int.Parse(Console.ReadLine());

    var filme = db.Filmes.Find(id);
    if (filme == null)
    {
        Console.WriteLine("Filme não encontrado.");
        return;
    }

    db.Filmes.Remove(filme);
    db.SaveChanges();

    Console.WriteLine($"\nFilme '{filme.Titulo}' deletado com sucesso!");
}