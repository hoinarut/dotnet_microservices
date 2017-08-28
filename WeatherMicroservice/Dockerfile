FROM microsoft/dotnet:1.1-sdk-msbuild

WORKDIR /app

COPY WeatherMicroservice.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/WeatherMicroservice.dll", "--server.urls", "http://0.0.0.0:5000"]



