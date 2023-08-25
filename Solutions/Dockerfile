FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Solutions/Solutions.csproj", "Solutions/"]
RUN dotnet restore "Solutions/Solutions.csproj"
COPY . .
WORKDIR "/src/Solutions"
RUN dotnet build "Solutions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Solutions.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Solutions.dll"]
