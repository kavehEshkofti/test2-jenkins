# Runtime-only Dockerfile
# Build, test, and publish are handled by Jenkins pipeline stages
FROM mcr.microsoft.com/dotnet/runtime:8.0

WORKDIR /app

# Copy the pre-built published output from the Jenkins workspace
COPY publish/ .

ENTRYPOINT ["dotnet", "SimpleConsoleApp.dll"]
