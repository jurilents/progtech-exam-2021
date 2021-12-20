# First stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

# Copy csproj and restore as distinct layers
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./ExamProg.WebApi.csproj"
RUN dotnet build "ExamProg.WebApi.csproj" -c Release -o /app/build

# Copy everything else and build website
FROM build AS publish
RUN dotnet publish "ExamProg.WebApi.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExamProg.WebApi.dll"]