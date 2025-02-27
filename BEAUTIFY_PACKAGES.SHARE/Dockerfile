# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the solution file and project files
COPY .dockerignore .
COPY README.md BEAUTIFY_PACKAGES.SHARE/
COPY BEAUTIFY_PACKAGES.sln .
COPY BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj ./BEAUTIFY_PACKAGES.SHARE/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the project files
COPY BEAUTIFY_PACKAGES.SHARE/ ./BEAUTIFY_PACKAGES.SHARE/

# Build the project
RUN dotnet build BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj --configuration Release --no-restore -p:TreatWarningsAsErrors=false -p:NoWarn=all

# Publish the project
RUN dotnet publish BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj -c Release -o out

# Pack the NuGet package (with no default excludes and no README required)
RUN dotnet pack BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj -c Release -o nupkg --no-restore

# Final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
COPY --from=build-env /app/nupkg ./nupkg

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "BEAUTIFY_PACKAGES.SHARE.dll"]