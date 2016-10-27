FROM microsoft/aspnetcore:1.0.1

# Copy
COPY ./bin/Release/netcoreapp1.0/publish /app

# Define
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "vNextDemo.dll"]

