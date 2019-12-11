FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Web1/Web1.csproj", "Web1/"]
COPY ["Lib1/Lib1.csproj", "Lib1/"]
COPY ["ASPDockerTest/ASPDockerTest.csproj", "ASPDockerTest/"]
RUN dotnet restore "Web1/Web1.csproj"
COPY . .
WORKDIR "/src/Web1"
RUN dotnet build "Web1.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Web1.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Web1.dll"]