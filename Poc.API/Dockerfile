#https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows

FROM mcr.microsoft.com/dotnet/aspnet:3.1

COPY bin/Debug/netcoreapp3.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "Poc.API.dll"]