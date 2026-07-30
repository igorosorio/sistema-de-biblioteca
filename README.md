# Sistema de Biblioteca

Sistema de gerenciamento de biblioteca desenvolvido em C# como projeto de estudo e portfólio, com foco em orientação a objetos, organização de código, regras de negócio e boas práticas de desenvolvimento backend.

> **Status:** Em desenvolvimento 🚧

## Sobre o projeto

O sistema tem como objetivo gerenciar livros, usuários, empréstimos e reservas de uma biblioteca.

O projeto está sendo desenvolvido de forma incremental, permitindo aplicar e aprofundar conceitos de C# e arquitetura de software ao longo de sua evolução.

## Funcionalidades

### Livros

* [x] Cadastro de livros
* [x] Remoção de livros
* [x] Busca por título
* [x] Busca por autor
* [x] Busca por ISBN
* [ ] Edição de livros
* [ ] Controle de quantidade disponível

### Usuários

* [ ] Cadastro de usuários
* [ ] Edição de usuários
* [ ] Bloqueio de usuários
* [ ] Consulta de usuários

### Empréstimos

* [ ] Realizar empréstimo
* [ ] Devolver livro
* [ ] Renovar empréstimo
* [ ] Controle de atraso

### Reservas

* [ ] Criar reserva
* [ ] Cancelar reserva
* [ ] Controle de status da reserva

### Persistência

* [ ] Persistência em arquivos JSON
* [ ] Abstração do acesso aos dados

### Futuras evoluções

* [ ] Testes automatizados
* [ ] Persistência em SQL Server
* [ ] Entity Framework Core
* [ ] Transformação em API REST com ASP.NET Core
* [ ] Autenticação e autorização

## Tecnologias

* C#
* .NET 8
* Programação Orientada a Objetos
* LINQ
* JSON
* ASP.NET Core *(futura evolução)*

## Estrutura do projeto

```text
SistemaDeBiblioteca
│
├── Enums
├── Menus
├── Models
├── Repositories
├── Services
├── Data
└── Program.cs
```

## Arquitetura

A aplicação está sendo organizada com separação de responsabilidades entre as principais camadas:

```text
Menu
  ↓
Service
  ↓
Repository
  ↓
Data
```

Os menus são responsáveis pela interação com o usuário, os serviços concentram as regras de negócio e os repositórios são responsáveis pelo acesso e persistência dos dados.

## Objetivo

Este projeto faz parte do meu processo de aprendizado em C# e desenvolvimento backend, com o objetivo de aplicar na prática conceitos de orientação a objetos, arquitetura de software, persistência de dados e desenvolvimento de aplicações.

O projeto continuará sendo evoluído conforme novos conhecimentos forem adquiridos.
