#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["custommigration.runner/custommigration.runner.csproj", "custommigration.runner/"]
COPY ["CustomerManagement.Data/CustomerManagement.Data.csproj", "CustomerManagement.Data/"]
RUN dotnet restore "custommigration.runner/custommigration.runner.csproj"
COPY . .
WORKDIR "/src/custommigration.runner"
RUN dotnet build "custommigration.runner.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "custommigration.runner.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Install dotnet tools
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef  --version 7.0.0

ENTRYPOINT ["dotnet", "custommigration.runner.dll"]