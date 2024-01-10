FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet build ./POC.Docker/POC.Docker.csproj -o ./build 
ENTRYPOINT ["dotnet", "/app/POC.Docker.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
EXPOSE 80
WORKDIR /app
COPY --from=build /src/build/. .
ENTRYPOINT ["dotnet", "/app/POC.Docker.dll"]