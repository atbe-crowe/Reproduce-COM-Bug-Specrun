FROM mcr.microsoft.com/azure-pipelines/vsts-agent

WORKDIR /src

COPY . .

RUN dotnet build /src/CroweTaxConnectTests/CroweTaxConnectTests.csproj

CMD dotnet test /src/CroweTaxConnectTests/CroweTaxConnectTests.csproj