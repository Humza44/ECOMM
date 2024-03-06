#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ECOMM.API/ECOMM.API.csproj", "ECOMM.API/"]
RUN dotnet restore "ECOMM.API/ECOMM.API.csproj"
COPY . .
WORKDIR "/src/ECOMM.API"
RUN dotnet build "ECOMM.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECOMM.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECOMM.API.dll"]