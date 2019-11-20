FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["CrudTest/CrudTest.csproj", "CrudTest/"]
RUN dotnet restore "CrudTest/CrudTest.csproj"
COPY . .
WORKDIR "/src/CrudTest"
RUN dotnet build "CrudTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CrudTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CrudTest.dll"]