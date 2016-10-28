# Base Image
FROM mono

# LABEL
LABEL author="efaruk"
LABEL version="1.0.0"
LABEL description="vNextDemo image based microsoft/aspnetcore"
MAINTAINER E. Faruk Pehlivanli

RUN apt-get update \
    && apt-get install nginx supervisor -y \
    && apt-get clean

# Copy
# COPY ./bin/Release /app
COPY ./docker/supervisord.conf /etc/supervisor/conf.d/supervisord.conf
COPY ./docker/nginx.conf /etc/nginx/sites-available/default

# Define
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["mono", "MonoDemo.exe"]

