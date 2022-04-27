FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CurvyCakes.Presentation/CurvyCakes.Presentation.csproj", "CurvyCakes.Presentation/"]
RUN dotnet restore "CurvyCakes.Presentation/CurvyCakes.Presentation.csproj"
COPY . .
WORKDIR "/src/CurvyCakes.Presentation"
RUN dotnet build "CurvyCakes.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CurvyCakes.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CurvyCakes.Presentation.dll"]