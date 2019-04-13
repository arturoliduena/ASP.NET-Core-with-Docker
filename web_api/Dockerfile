FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY web_api.csproj web_api/
RUN dotnet restore web_api/web_api.csproj
WORKDIR /src/web_api
COPY . .
RUN dotnet build web_api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish web_api.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "web_api.dll"]