# Stage 1: Build and Package
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy only necessary files for restore
COPY README.md BEAUTIFY_PACKAGES.SHARE/
COPY BEAUTIFY_PACKAGES.sln .
COPY BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj BEAUTIFY_PACKAGES.SHARE/
RUN dotnet restore

# Copy the rest of the project files
COPY BEAUTIFY_PACKAGES.SHARE/ BEAUTIFY_PACKAGES.SHARE/

# Build and publish in a single step (avoids redundant build steps)
RUN dotnet publish BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj \
    --configuration Release \
    --no-restore \
    --output /app/out

# Pack the NuGet package
RUN dotnet pack BEAUTIFY_PACKAGES.SHARE/BEAUTIFY_PACKAGES.SHARE.csproj \
    --configuration Release \
    --output /app/nupkg \
    --no-restore

# Stage 2: Runtime Image (Minimal Final Image)
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy only the built application and NuGet package from the build stage
COPY --from=build-env /app/out . 
COPY --from=build-env /app/nupkg ./nupkg

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "BEAUTIFY_PACKAGES.SHARE.dll"]
