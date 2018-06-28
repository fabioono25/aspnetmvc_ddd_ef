# Sobre

Este projeto foi inspirado no vídeo do Eduardo Pires sobre DDD, IoC, Automapper. [https://www.youtube.com/watch?v=i9Il79a2uBU](https://www.youtube.com/watch?v=i9Il79a2uBU)

Como principais atualizações, temos a adoção do .NET Core Simple Injector.

## Modelo DDD

![](https://github.com/fabioono25/aspnetmvc_ddd_ef/blob/master/ddd.jpg)

### Tecnologias

- DDD;
- Repositório Genérico e Especializado;
- Migrations/Code-First;
- FluentAPI;
- Automapper, utilizando SimpleInjector;
- ASP.NET MVC Core 2.0
- .NET Standard 2.0

### Melhorias Necessárias

- Refactoring do código;
- Utilização de programação funcional em pontos determinados da aplicação
- Retirar dependência da camada de repositório do projeto MVC
- Utilização do FluentValidation para a validação das entidades de domínio
- Correção/refactoring dos Produtos
- Criar um projeto de CrossCutting->IoC, objetivando retirar a dependência da camada de Front (MVC) do repositório.

