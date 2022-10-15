FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DotnetCoreK8s/DotnetCoreK8s.csproj", "DotnetCoreK8s/"]
RUN dotnet restore "DotnetCoreK8s/DotnetCoreK8s.csproj"
COPY . .
WORKDIR "/src/DotnetCoreK8s"
RUN dotnet build "DotnetCoreK8s.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetCoreK8s.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetCoreK8s.dll"]