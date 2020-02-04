FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ChatPOC/ChatPOC.csproj", "ChatPOC/"]
RUN dotnet restore "ChatPOC/ChatPOC.csproj"
COPY . .
WORKDIR "/src/ChatPOC"
RUN dotnet build "ChatPOC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChatPOC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChatPOC.dll"]