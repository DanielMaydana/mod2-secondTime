#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Yachaq.Trainers.Service/Yachaq.Trainers.Service.csproj", "Yachaq.Trainers.Service/"]
RUN dotnet restore "Yachaq.Trainers.Service/Yachaq.Trainers.Service.csproj"
COPY . .
WORKDIR "/src/Yachaq.Trainers.Service"
RUN dotnet build "Yachaq.Trainers.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Yachaq.Trainers.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Yachaq.Trainers.Service.dll"]