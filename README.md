# Projeto DIO - API .NET + MongoDB

## Objetivos

Projeto prático de construção de uma aplicação API em .NET para exercitar conceitos das aulas e framework MVC. Esse projeto consiste em um único endpoint `/infectado` com os tipos de requisições mais usuais: GET, POST, PATCH, DELETE, realizando operações CRUD. O banco de dados utilizado é o
MongoDB, com servido na nuvem através do serviço ofertado pelo próprio MongoDb: [Cloud MongoDB](http://cloud.mongodb.com).

## Tecnologias

- .NET
- MongoDB (+ serviço cloud [Cloud MongoDB](http://cloud.mongodb.com) )

## Rodando a aplicação

Para rodar a aplicação é necessário a configuração através de um arquivo `appsettings.json` para referencia o banco de dados. Com tudo pronto, basta rodar `dotnet run` na linha de comando dentro da pasta da aplicação e começar a fazer requisições no endpoit `https://localhost:5001/infectado/`  🤓