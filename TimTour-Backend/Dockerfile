# See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TimTour-Backend/TimTour-Backend.csproj", "TimTour-Backend/"]
COPY ["TimTour-Backend.API/TimTour-Backend.API.csproj", "TimTour-Backend.API/"]
COPY ["TimTour-Backend.Data/TimTour-Backend.Data.csproj", "TimTour-Backend.Data/"]
COPY ["TimTour-Backend.Business/TimTour-Backend.Business.csproj", "TimTour-Backend.Business/"]
RUN dotnet restore "TimTour-Backend/TimTour-Backend.csproj"
COPY . .
WORKDIR "/src/TimTour-Backend"
RUN dotnet build "TimTour-Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimTour-Backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "TimTour-Backend.dll"]
