
# Use a imagem base do SDK do .NET Core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

# Copie os arquivos do projeto para o container
COPY . ./

# Restaurar dependências e compilar
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Imagem final
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

COPY --from=build-env /app/out .

# Comando para iniciar o aplicativo quando o contêiner for iniciado
ENTRYPOINT ["dotnet", "CreditProcessingAPI.dll"]
