# AgendaTelefonicaWeb


 Essa e uma aplicaçao `C#` com `.NET 7.0` usando o `Entity Framework` alem de diversas
 dependencias que voce pode ver no arquivo `.csproj`.
 Usando os conceitos de orientaçao a objeto e uma estrutura API baseada em DDD `(Design-Driven Development)`
 trazendo o maximo de responsividade e conseitos muito usado no mercado fazendo o maximo para ter um codigo limpo ou "clean code"



## Funcionalidades



- Criar contatos
- Buscar um contatos
- Buscar todos os contatos
- Atualizar um contatos
- Excluir um contatos
- Tratamento de erro

## Funcionalidades Futuras

- Validações nos campos
- Pesquisar um contatos através do numero
- Testes Unitario com Xunit

## Como funciona

A Api e baseada em uma agenda telefonica, onde voce pode adicionar seus contatos, e eles sao apenas seus.
pensando nisso foi projetada para que apos o login com seu numero, voce tenha uma agenda apenas com toda 
segurança implementada atravesdo JTW gerando tokens de segurança. 
Uma vez logado o usuario pode consultar todos os numero ou obter pelo id atribuido aqueles dados.

apenas o `Nome` e `Numero` sao `obrigatorios` deixando os outros dados opcionais.

## Forma de Testar

apos voce fazer todos os passos Bixo ensinando clonar o projeto voce ira precisar ter um banco de dados `Postgres`
mas caso queria usar outro, fique a vontade para fazer as alteraçoes.
logando em sua conta ele fornecerar um token que voce copiara e subirar ate `Authorize` 
la voce precisara escrever `Bearer` `colar tokem copiado depois dessa palavra`.
 agora voce estar logado e pode adicionar, consultar, atualizar ate deletar contato.

## 📥 download

Antes de começar, você precisará ter as seguintes ferramentas instaladas em sua máquina:
[Git](https://git-scm.com).
Além disso, é bom ter um editor para trabalhar com código como [VSCode](https://code.visualstudio.com/).

### 💻 setup

```php
# clonar este repositório
$ git clone https://https://github.com/MaxsuelsSouza/AgendaTelefonicaWeb

# acesse a pasta do projeto 
$ cd src/ AgendaTelefonica.Api

# digite esse comando
$ dotnet build
