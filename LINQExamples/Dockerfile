FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LINQExamples/LINQExamples.csproj", "LINQExamples/"]
RUN dotnet restore "LINQExamples/LINQExamples.csproj"
COPY . .
WORKDIR "/src/LINQExamples"
RUN dotnet build "LINQExamples.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LINQExamples.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LINQExamples.dll"]
