FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ElevatorSimulator/ElevatorSimulator.csproj", "ElevatorSimulator/"]
RUN dotnet restore "ElevatorSimulator/ElevatorSimulator.csproj"
COPY . .
WORKDIR "/src/ElevatorSimulator"
RUN dotnet build "ElevatorSimulator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ElevatorSimulator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ElevatorSimulator.dll"]
