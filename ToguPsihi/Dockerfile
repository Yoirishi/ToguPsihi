#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5076:5076


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ToguPsihi.csproj ToguPsihi.csproj 
RUN dotnet restore ToguPsihi.csproj
COPY . .
WORKDIR /src
COPY testOne.db testOne.db
RUN dotnet build ToguPsihi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ToguPsihi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY testOne.db testOne.db
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToguPsihi.dll"]