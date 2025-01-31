FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the .csproj file to the working directory
COPY ["MyPublicAPI.csproj", "./"]

# Restore dependencies
RUN dotnet restore "MyPublicAPI.csproj"

# Copy the rest of the application files
COPY . .

# Set the working directory to the project folder
WORKDIR "/src"

# Build the application
RUN dotnet build "MyPublicAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyPublicAPI.csproj" -c Release -o /app/publish

# Use the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPublicAPI.dll"]

