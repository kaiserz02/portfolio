# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["kbdesilva/kbdesilva.csproj", "kbdesilva/"]
RUN dotnet restore "kbdesilva/kbdesilva.csproj"
COPY . .
WORKDIR "/src/kbdesilva"
RUN dotnet build "kbdesilva.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kbdesilva.csproj" -c Release -o /app/publish

# Final stage: Copy the build app and run it using the ASP.NET Core runtime
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourBlazorApp.dll"]
