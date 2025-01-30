# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyPublicAPI/MyPublicAPI.csproj", "MyPublicAPI/"]
RUN dotnet restore "MyPublicAPI/MyPublicAPI.csproj"
COPY . .
WORKDIR "/src/MyPublicAPI"
RUN dotnet build "MyPublicAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyPublicAPI.csproj" -c Release -o /app/publish

# Copy build app to base image and run it
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPublicAPI.dll"]

