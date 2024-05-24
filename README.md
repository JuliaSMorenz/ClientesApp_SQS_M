# AgendaApp

O AgendaApp é um sistema de controle de tarefas desenvolvido em ASP.NET API com o uso do Entity Framework, seguindo os princípios de Domain-Driven Design (DDD).

## Pré-requisitos

Para executar este projeto, você precisará do seguinte:

- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/) com .NET 8 instalado.
- Um banco de dados SQL Server. Você precisará criar um banco de dados local e atualizar a string de conexão no arquivo `DataContext.cs`.

## Configuração do Banco de Dados

Após configurar o banco de dados local e atualizar a string de conexão no arquivo DataContext.cs, execute o comando 'Update-Database' no Console do Gerenciador de Pacotes do Visual Studio para aplicar as migrações e criar as tabelas necessárias.

## Documentação

- Documentação do ASP.NET API: [ASP.NET API Documentation](https://docs.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-8.0)
- Documentação do Entity Framework Core: [Entity Framework Core Documentation](https://docs.microsoft.com/pt-br/ef/core/)

## Swagger

Este projeto inclui uma documentação interativa da API usando o Swagger. Após iniciar o aplicativo, você pode acessar a interface Swagger em `/swagger` para explorar e testar os endpoints da API.

## Code-First

O AgendaApp utiliza o padrão Code-First para definir o modelo de dados. Isso significa que as entidades e relacionamentos são definidos em classes C# e o banco de dados é gerado automaticamente a partir dessas definições.

## Injeção de Dependência

A aplicação faz uso extensivo de injeção de dependência para promover a modularidade e a testabilidade do código. As dependências são injetadas nos componentes da aplicação em vez de serem instanciadas dentro do próprio componente.

## DDD - Domain-Driven Design

O projeto segue os princípios de Domain-Driven Design (DDD) para organizar e estruturar o código em torno do domínio da aplicação. Isso inclui a separação clara entre as camadas de aplicação, domínio e infraestrutura, promovendo um design mais coeso e orientado ao negócio.