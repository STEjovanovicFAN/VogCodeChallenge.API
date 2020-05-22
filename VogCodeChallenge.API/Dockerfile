FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52386
EXPOSE 44363

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["VogCodeChallenge.API/VogCodeChallenge.API.csproj", "VogCodeChallenge.API/"]
RUN dotnet restore "VogCodeChallenge.API/VogCodeChallenge.API.csproj"
COPY . .
WORKDIR "/src/VogCodeChallenge.API"
RUN dotnet build "VogCodeChallenge.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VogCodeChallenge.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VogCodeChallenge.API.dll"]