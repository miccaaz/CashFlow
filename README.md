
# 💰 CashFlow

O **CashFlow** é uma API REST desenvolvida para gerenciamento de despesas de usuários, permitindo operações completas de CRUD (Create, Read, Update, Delete).

O projeto foi construído seguindo boas práticas de desenvolvimento backend, com foco em organização, testabilidade e escalabilidade.


## 🚀 Funcionalidades

* 📌 Cadastro de despesas
* 📖 Consulta de despesas
* ✏️ Atualização de despesas
* ❌ Remoção de despesas
* 👤 Associação de despesas a usuários


## 🧱 Arquitetura

O projeto utiliza **arquitetura em camadas**, separando responsabilidades para manter o código limpo e organizado:

* **Camada de Apresentação**: Controllers e endpoints da API
* **Camada de Aplicação/Serviços**: Regras de negócio
* **Camada de Domínio**: Entidades e contratos
* **Camada de Infraestrutura**: Acesso a dados e integrações externas


## 🛠️ Tecnologias Utilizadas

* **.NET (C#)**
* **ASP.NET Core**
* **Entity Framework Core**
* **Banco de Dados Relacional**
* **Injeção de Dependência nativa do .NET**
* **Testes automatizados (unitários e/ou integração)**


## 🧪 Testes

O projeto conta com testes automatizados para garantir a qualidade e confiabilidade das funcionalidades implementadas.

* Testes unitários para regras de negócio
* Possível uso de mocks para isolamento de dependências


## 🔌 Injeção de Dependência

Foi utilizada a injeção de dependência nativa do ASP.NET Core, promovendo:

* Baixo acoplamento
* Facilidade de testes
* Melhor organização do código


## 🗄️ Banco de Dados

A API está integrada a um banco de dados relacional, utilizando o Entity Framework Core para:

* Mapeamento objeto-relacional (ORM)
* Migrações
* Persistência de dados


## 📂 Estrutura do Projeto (Exemplo)

```
CashFlow/
│
├── Controllers/
├── Application/
├── Domain/
├── Infrastructure/
├── Tests/
└── Program.cs
```


## ▶️ Como Executar o Projeto

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/cashflow.git
```

2. Acesse a pasta:

```bash
cd cashflow
```

3. Restaure as dependências:

```bash
dotnet restore
```

4. Execute as migrações (se aplicável):

```bash
dotnet ef database update
```

5. Rode a aplicação:

```bash
dotnet run
```


## 📌 Endpoints (Exemplo)

| Método | Rota           | Descrição         |
| ------ | -------------- | ----------------- |
| GET    | /expenses      | Lista despesas    |
| GET    | /expenses/{id} | Busca por ID      |
| POST   | /expenses      | Cria nova despesa |
| PUT    | /expenses/{id} | Atualiza despesa  |
| DELETE | /expenses/{id} | Remove despesa    |
