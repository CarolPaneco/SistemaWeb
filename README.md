# SistemaConsultaEstoque

## Descrição
O **SistemaConsultaEstoque** é uma aplicação web desenvolvida em ASP.NET Core para gerenciamento de estoque de uma fazenda urbana. O sistema permite o cadastro e controle de produtos, fornecedores, clientes, compras e vendas, oferecendo uma interface amigável para consultar e registrar operações do dia a dia.

## Funcionalidades
- **Gerenciamento de Estoque**: Adicionar, editar e visualizar produtos disponíveis.
- **Cadastro de Clientes**: Registro de clientes com informações como nome, CPF/CNPJ, endereço e contato.
- **Cadastro de Fornecedores**: Inclusão de fornecedores com dados completos.
- **Registro de Compras e Vendas**: Controle de transações de compra e venda com histórico detalhado.
- **Relatórios**: Geração de relatórios de vendas e estoque.

## Tecnologias Utilizadas
- **ASP.NET Core**: Framework para desenvolvimento web.
- **Entity Framework Core**: ORM para interagir com o banco de dados.
- **SQL Server**: Banco de dados relacional.
- **HTML5, CSS3**: Interface do usuário.
- **Git e GitHub**: Controle de versão.

## Configuração do Projeto
### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/)

### Clonando o Repositório
```bash
git clone https://github.com/CarolPaneco/SistemaWeb.git

### Executando o Projeto
Abra o projeto no Visual Studio.
Configure a string de conexão com o SQL Server no arquivo appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=SistemaFazendaDB;Trusted_Connection=True;"
}

Execute as migrações para criar o banco de dados:

dotnet ef database update
Inicie o projeto:

dotnet run

### Estrutura do Banco de Dados
Clientes: Cadastro de clientes.
Fornecedores: Cadastro de fornecedores.
Produtos: Itens registrados no estoque.
Compras e Vendas: Histórico de transações.


### Contato
Desenvolvedora: Caroline Vitória Paneco
E-mail: cpaneco@gmail.com
SistemaConsultaEstoque - Um projeto para gestão inteligente de estoques em fazendas urbanas.


