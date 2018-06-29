# Sobre

Este projeto foi inspirado no vídeo do Eduardo Pires sobre DDD, IoC, Automapper. [Link](http://www.eduardopires.net.br/2014/10/tutorial-asp-net-mvc-5-ddd-ef-automapper-ioc-dicas-e-truques/)

Como principais atualizações, temos a adoção do .NET Core Simple Injector.

## Modelo DDD

![](https://github.com/fabioono25/aspnetmvc_ddd_ef/blob/master/ddd1.jpg)

### Tecnologias

- DDD;
- Repositório Genérico e Especializado;
- Migrations/Code-First;
- FluentAPI;
- Automapper
- IoC e DI, utilizando SimpleInjector;
- ASP.NET MVC Core 2.0
- .NET Standard 2.0

### Melhorias Necessárias

- Refactoring do código;
- Utilização de programação funcional em pontos determinados da aplicação
- Projeto de Testes Unitários
- Retirar dependência da camada de repositório do projeto MVC
- Utilização do FluentValidation para a validação das entidades de domínio
- Correção/refactoring dos Produtos
- Criar um projeto de CrossCutting->IoC, objetivando retirar a dependência da camada de Front (MVC) do repositório.

