# 🎬 Catálogo de Filmes e Séries - Aplicação Console

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white )
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white )
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white )
![SQLite](https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite&logoColor=white )

> Projeto criado para o checkpoint 5 da matéria de C# Development.

## 👩‍🎓 Alunos
- Camila do Prado Padalino - RM98316
- Gabriel Teixeira Machado - RM551570
- João Pedro de Souza Vieira - RM99805

## 📝 Sobre o Projeto

Este projeto é uma aplicação de console desenvolvida em **C#** com **.NET** para gerenciar um catálogo pessoal de filmes. O objetivo principal foi aplicar conceitos fundamentais de desenvolvimento de software, com foco na interação com um banco de dados utilizando **Entity Framework Core**.

A aplicação permite ao usuário realizar as quatro operações básicas de persistência de dados (CRUD - Create, Read, Update, Delete) para a entidade `Filme`, demonstrando o domínio sobre o mapeamento objeto-relacional (ORM) e a manipulação de dados em um ambiente .NET.

## ✨ Funcionalidades

O sistema oferece um menu interativo via terminal que permite:

*   **Gerenciamento de Filmes:**
    *   Adicionar um novo filme, associando-o a um gênero existente.
    *   Listar todos os filmes cadastrados, exibindo seus detalhes e gênero.
    *   Atualizar as informações de um filme existente (título e ano).
    *   Remover um filme do catálogo.

## 🛠️ Tecnologias Utilizadas

*   **[C#](https://docs.microsoft.com/pt-br/dotnet/csharp/ )**: Linguagem de programação principal para toda a lógica da aplicação.
*   **[.NET (9.0)](https://dotnet.microsoft.com/ )**: Plataforma de desenvolvimento utilizada para construir a aplicação.
*   **[Entity Framework Core (9.0)](https://docs.microsoft.com/pt-br/ef/core/ )**: ORM (Object-Relational Mapper) utilizado para a camada de acesso a dados, abstraindo a comunicação com o banco.
*   **[SQLite](https://www.sqlite.org/index.html )**: Banco de dados relacional leve e baseado em arquivo, ideal para desenvolvimento local e aplicações embarcadas.


## 🚀 Como Executar o Projeto

Para executar este projeto em sua máquina local, siga os passos abaixo.

### Pré-requisitos

*   [.NET SDK](https://dotnet.microsoft.com/download ) (versão 9.0 ou superior).
*   Ferramenta de linha de comando `dotnet-ef` instalada globalmente. Se não tiver, instale com o comando:
    ```sh
    dotnet tool install --global dotnet-ef
    ```

### Passos para Execução

1.  **Clone o repositório** ou baixe os arquivos do projeto para uma pasta em seu computador.

2.  **Abra um terminal** na pasta raiz do projeto (`CatalogoFilmes/`).

3.  **Restaure as dependências** do projeto (pacotes NuGet):
    ```sh
    dotnet restore
    ```

4.  **Crie o banco de dados** a partir das migrations. Este comando criará o arquivo `catalogo.db` com as tabelas `Filmes` e `Generos`.
    ```sh
    dotnet ef database update
    ```

5.  **Execute a aplicação**:
    ```sh
    dotnet run
    ```

Após executar o último comando, o menu interativo do catálogo de filmes aparecerá no seu terminal.

---
_Projeto desenvolvido como parte de um estudo prático sobre desenvolvimento de software com tecnologias .NET._


