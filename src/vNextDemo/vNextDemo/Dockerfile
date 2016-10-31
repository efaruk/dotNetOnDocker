# Base Image
FROM microsoft/aspnetcore:1.0.1

# LABEL
LABEL author="efaruk"
LABEL version="1.0.0"
LABEL description="vNextDemo image based microsoft/aspnetcore"
MAINTAINER E. Faruk Pehlivanli

# Copy
COPY ./bin/Debug/netcoreapp1.0/publish /app

# Define
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "vNextDemo.dll"]

