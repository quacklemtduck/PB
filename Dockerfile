# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY . /source
WORKDIR /source/Server

RUN dotnet restore

RUN dotnet build
RUN dotnet dev-certs https

ENTRYPOINT ["dotnet", "run"]