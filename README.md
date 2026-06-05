# ApiTresCamadas

Projeto desenvolvido em **.NET 10** como demonstração prática dos conceitos apresentados no curso **Projetando Arquiteturas em Três Camadas**, da plataforma Desenvolvedor.IO, ministrado pelo professor Eduardo Pires.

## 📖 Sobre o Projeto

O **ApiTresCamadas** é uma API REST construída utilizando a arquitetura em três camadas, com o objetivo de demonstrar boas práticas de desenvolvimento, separação de responsabilidades e organização de projetos em aplicações .NET.

A solução foi estruturada para facilitar a manutenção, escalabilidade e testabilidade do sistema, seguindo princípios de arquitetura de software amplamente utilizados no mercado.

## 🏗️ Arquitetura

O projeto está dividido em três camadas principais:

### 1. Apresentação (API)

Responsável por expor os endpoints REST, receber as requisições dos clientes e retornar as respostas adequadas.

### 2. Negócio (Business)

Contém as regras de negócio da aplicação, validações e serviços responsáveis pelo processamento das informações.

### 3. Dados (Data)

Responsável pelo acesso ao banco de dados através do padrão Repository e da utilização do Entity Framework Core.

## 🚀 Tecnologias Utilizadas

* .NET 10
* ASP.NET Core Web API
* Entity Framework Core
* AutoMapper
* Swagger / OpenAPI
* Dependency Injection
* Repository Pattern
* Fluent Validation
* SQL Server

## 📂 Estrutura do Projeto

```text
src/
├── DevIo.Api
├── DevIo.Business
└── DevIo.Data

```

## ⚙️ Pré-requisitos

Antes de executar o projeto, certifique-se de possuir instalado:

* .NET 10 SDK
* SQL Server
* Visual Studio 2022 ou superior
* Git

## 🔧 Executando o Projeto

### Clone o repositório

```bash
git clone https://github.com/wbleiner/ApiTresCamadas.git
```

### Acesse a pasta do projeto

```bash
cd ApiTresCamadas
```

### Restaure os pacotes

```bash
dotnet restore
```

### Execute as migrations

```bash
dotnet ef database update
```

### Inicie a aplicação

```bash
dotnet run --project src/DevIo.Api
```

## 📚 Documentação da API

Após iniciar a aplicação, a documentação estará disponível através do Swagger:

```text
https://localhost:7128/swagger
```

ou

```text
http://localhost:5282/swagger
```

## 🎯 Objetivos de Aprendizagem

Este projeto tem como objetivo demonstrar:

* Arquitetura em três camadas
* Separação de responsabilidades
* Injeção de dependência
* Organização de soluções .NET
* Utilização do Entity Framework Core
* Implementação do padrão Repository
* Boas práticas de desenvolvimento de APIs REST
* Estruturação de projetos para manutenção e escalabilidade

## 👨‍🏫 Créditos

Projeto desenvolvido como estudo e prática dos conceitos apresentados no curso **Projetando Arquiteturas em Três Camadas**, da plataforma **Desenvolvedor.IO**, ministrado por **Eduardo Pires**.

## 📄 Licença

Este projeto possui finalidade exclusivamente educacional e de aprendizado.
