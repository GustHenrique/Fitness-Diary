# 🏋️‍♂️ Fitness-Diary: Passo a Passo para Rodar o Projeto

Este guia irá ajudá-lo a configurar e rodar o projeto **Fitness-Diary**.

## 1. Clone o Repositório

Abra o terminal ou Git Bash e execute os seguintes comandos para clonar o repositório e entrar no diretório do projeto:

```bash
git clone https://github.com/GustHenrique/Fitness-Diary.git
cd Fitness-Diary
```
## 2. Configure o Banco e dados
```bash
Crie um servidor do banco de dados SqlServer e salve o seu nome para utilizar no próximo passo.

Crie um banco de dados chamado "DIARIO_SAUDE"

Crie um logon owner no banco DIARIO_SAUDE com id e senha, salve para utilizar no proximo passo.
```


## 3. Configuração conexão com banco
Abra o projeto clonado com o visual studio e atualize o arquivo appsettings.json: 
```bash
Atualize a tag DefaultConnection com as informações cadastradas anteriormente no banco de dados

"ConnectionStrings": {
  "DefaultConnection": "Server={exemplo-nome-servidor};Database=DIARIO_SAUDE;User Id = {exemplo_id};Password={exemplo_senha};TrustServerCertificate=True;"
},
```

## 4. Realizar o migration
Abra o console do gerenciador de pacotes e digite:
```bash
dotnet restore

Add-Migration InitialCreate

Update-Database
```

## 5. Fim
Agora, basta executar o projeto no Visual Studio. Se tudo estiver configurado corretamente, o projeto estará rodando e conectado ao banco de dados.
