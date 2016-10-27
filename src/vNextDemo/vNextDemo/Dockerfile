FROM microsoft/aspnetcore:1.0.1

# Copy
COPY ./bin/Release/netcoreapp1.0/publish /app

# Define
ENV ASPNETCORE_URLS http://*:8889
EXPOSE 8889
ENTRYPOINT ["dotnet", "app/vNextDemo.dll"]
