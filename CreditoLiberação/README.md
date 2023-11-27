Credit Processing API
Esta é uma API simples para processamento de solicitações de crédito, onde é possível enviar uma requisição para análise de crédito com base em algumas regras predefinidas.

Funcionalidades
Processamento de Crédito: Envie uma solicitação de crédito com informações sobre o valor, tipo, número de parcelas e data do primeiro vencimento para obter uma decisão de aprovação ou recusa, juntamente com detalhes dos juros.
Tecnologias Utilizadas
.NET Core
C#

Como Usar
Pré-requisitos
.NET Core 3.1 ou superior

Executando Localmente

Clone este repositório:
git clone https://github.com/seu-usuario/credit-processing-api.git

Navegue até o diretório do projeto:
cd credit-processing-api

Execute o aplicativo usando o comando:
dotnet run

Faça solicitações para a API usando seu cliente HTTP preferido, como curl ou ferramentas como Postman ou Insomnia, no endpoint:
POST http://localhost:8080/credit/process

Exemplo de corpo da requisição:
{
    "CreditAmount": 50000,
    "Type": 4,
    "Installments": 12,
    "FirstDueDate": "2023-12-10"
}

Docker
Também é possível executar a aplicação como um contêiner Docker:

Certifique-se de ter o Docker instalado.

No diretório do projeto, construa a imagem Docker:

docker build -t credit-processing-api .

Execute a imagem em um contêiner:

docker run -d -p 8080:80 --name credit-api-app credit-processing-api




