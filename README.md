README — Zeladoria Urbana API

Sistema backend desenvolvido com ASP.NET Core utilizando Clean Architecture, Entity Framework Core e PostgreSQL.

📌 Tecnologias Utilizadas
ASP.NET Core Web API
.NET 9 (recomendado migrar futuramente para .NET 8 LTS)
Entity Framework Core
PostgreSQL
Swagger/OpenAPI
Clean Architecture
Repository Pattern
Dependency Injection
📂 Estrutura do Projeto
ZeladoriaPessoal
│
├── ZeladoriaUrbana.sln
│
├── ZeladoriaUrbana.Api
│   ├── Controllers
│   ├── Middleware
│   ├── Filters
│   ├── Configurations
│   ├── DependencyInjection
│   └── Program.cs
│
├── ZeladoriaUrbana.Application
│   ├── Services
│   ├── DTOs
│   ├── Interfaces
│   ├── Validators
│   └── Mappings
│
├── ZeladoriaUrbana.Domain
│   ├── Models
│   ├── Repositories
│   ├── Enums
│   ├── Exceptions
│   └── Rules
│
└── ZeladoriaUrbana.Infrastructure
    ├── DataAccess
    │   ├── Context
    │   ├── Repositories
    │   └── Migrations
    │
    ├── Services
    └── DependencyInjection
⚙️ Pré-requisitos

Antes de iniciar, instale:

.NET SDK 9
PostgreSQL
Git
Visual Studio 2022
OU
VS Code
🛠️ Configuração do Banco
Criar banco PostgreSQL

Abra o PostgreSQL e execute:

CREATE DATABASE zeladoria;
🔧 Configuração da Connection String

Abra:

ZeladoriaUrbana.Api/appsettings.json

Configure:

{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=zeladoria;Username=postgres;Password=SUA_SENHA"
  }
}
📦 Instalar Dependências

Na raiz do projeto execute:

dotnet restore
🔨 Compilar Projeto
dotnet build
🧱 Executar Migrations

Instale a ferramenta EF Core globalmente:

dotnet tool install --global dotnet-ef
📁 Criar Migration

Na raiz da solution:

dotnet ef migrations add InitialCreate \
--project ZeladoriaUrbana.Infrastructure \
--startup-project ZeladoriaUrbana.Api
🗄️ Atualizar Banco
dotnet ef database update \
--project ZeladoriaUrbana.Infrastructure \
--startup-project ZeladoriaUrbana.Api
▶️ Executar API

Entre na API:

cd ZeladoriaUrbana.Api

Execute:

dotnet run
🌐 API Rodando

A API ficará disponível em:

http://localhost:5115
📮 Endpoint Disponível
Criar Chamado
POST
/api/chamados
📥 Exemplo de Requisição
{
  "nomeUsuario": "Fabio",
  "telefone": "11999999999",
  "descricao": "Poste apagado na avenida"
}
📤 Exemplo de Resposta
{
  "id": "guid",
  "protocolo": "PROT-123456",
  "status": "Aberto"
}
🧪 Testando API

Recomendado utilizar:

Postman
Insomnia
🔀 Git — Primeiro Push
Inicializar repositório
git init
Adicionar arquivos
git add .
Commit inicial
git commit -m "Primeira versão do projeto"
Adicionar repositório remoto
git remote add origin URL_DO_REPOSITORIO
Branch principal
git branch -M main
Enviar para GitHub
git push -u origin main
☁️ Deploy Azure
Recomendado
Azure App Service
Plano Free F1
Região East US
🔐 Variáveis Ambiente Azure

Adicionar no App Service:

Nome
ConnectionStrings__DefaultConnection
Valor
Host=localhost;Port=5432;Database=zeladoria;Username=postgres;Password=SENHA
🚀 Funcionalidades Atuais

✅ Cadastro de chamados
✅ Persistência PostgreSQL
✅ Entity Framework Core
✅ Repository Pattern
✅ Clean Architecture
✅ Dependency Injection
✅ API REST

📌 Melhorias Futuras
JWT Authentication
Upload de imagens
Dashboard administrativo
Logs com Serilog
Middleware global
FluentValidation
Swagger completo
Integração com IA
Geolocalização
WebSocket
Notificações em tempo real
👨‍💻 Autor

Projeto desenvolvido para estudo e evolução profissional utilizando arquitetura moderna com ASP.NET Core.
