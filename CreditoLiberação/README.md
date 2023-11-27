Credit Processing API
Esta � uma API simples para processamento de solicita��es de cr�dito, onde � poss�vel enviar uma requisi��o para an�lise de cr�dito com base em algumas regras predefinidas.

Funcionalidades
Processamento de Cr�dito: Envie uma solicita��o de cr�dito com informa��es sobre o valor, tipo, n�mero de parcelas e data do primeiro vencimento para obter uma decis�o de aprova��o ou recusa, juntamente com detalhes dos juros.
Tecnologias Utilizadas
.NET Core
C#

Como Usar
Pr�-requisitos
.NET Core 3.1 ou superior

Executando Localmente

Clone este reposit�rio:
git clone https://github.com/seu-usuario/credit-processing-api.git

Navegue at� o diret�rio do projeto:
cd credit-processing-api

Execute o aplicativo usando o comando:
dotnet run

Fa�a solicita��es para a API usando seu cliente HTTP preferido, como curl ou ferramentas como Postman ou Insomnia, no endpoint:
POST http://localhost:8080/credit/process

Exemplo de corpo da requisi��o:
{
    "CreditAmount": 50000,
    "Type": 4,
    "Installments": 12,
    "FirstDueDate": "2023-12-10"
}

Docker
Tamb�m � poss�vel executar a aplica��o como um cont�iner Docker:

Certifique-se de ter o Docker instalado.

No diret�rio do projeto, construa a imagem Docker:

docker build -t credit-processing-api .

Execute a imagem em um cont�iner:

docker run -d -p 8080:80 --name credit-api-app credit-processing-api




