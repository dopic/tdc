
FROM microsoft/dotnet:1.0-core

COPY ./bin/Debug/netcoreapp1.0/publish/ /app

WORKDIR /app
 
EXPOSE 5001

CMD ["dotnet", "app.dll"]

