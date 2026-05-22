# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files and restore
COPY src/SimpleConsoleApp/SimpleConsoleApp.csproj src/SimpleConsoleApp/
COPY tests/SimpleConsoleApp.Tests/SimpleConsoleApp.Tests.csproj tests/SimpleConsoleApp.Tests/
COPY SimpleConsoleApp.sln .
RUN dotnet restore SimpleConsoleApp.sln

# Copy everything and build
COPY . .
RUN dotnet build SimpleConsoleApp.sln --configuration Release --no-restore

# Run tests
RUN dotnet test SimpleConsoleApp.sln --configuration Release --no-build --logger "trx;LogFileName=test-results.trx"

# Publish
RUN dotnet publish src/SimpleConsoleApp/SimpleConsoleApp.csproj --configuration Release --no-build -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "SimpleConsoleApp.dll"]
