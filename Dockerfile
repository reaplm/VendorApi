#See https://aka.ms/containerfastmode to understand how Visual Studio uses 
#this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN apt-get update 
RUN apt-get install -y curl

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

#COPY "Vendor.sln" "Vendor.sln"

COPY "Vendor.Api/Vendor.Api.csproj" "Vendor.Api/"
COPY "Vendor.Application/Vendor.Application.csproj" "Vendor.Application/"
COPY "Vendor.Domain/Vendor.Domain.csproj" "Vendor.Domain/"
COPY "Vendor.Infrastructure/Vendor.Infrastructure.csproj" "Vendor.Infrastructure/"

RUN dotnet restore "Vendor.Api/Vendor.Api.csproj"

COPY . .
WORKDIR /src/Vendor.Api
RUN pwd && ls
RUN dotnet build "Vendor.Api.csproj" -c Release -o /app
#RUN dotnet publish --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish "Vendor.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Vendor.Api.dll", "--environment=Development"]
