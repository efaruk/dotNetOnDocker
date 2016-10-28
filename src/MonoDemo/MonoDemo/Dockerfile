# Base Image
FROM mono

# LABEL
LABEL author="efaruk"
LABEL version="1.0.0"
LABEL description="MonoDemo image based mono"
MAINTAINER E. Faruk Pehlivanli

RUN apt-get update \
    && apt-get install nginx supervisor -y \
    && apt-get clean

# Copy
# COPY ./bin/Release /app
COPY ./docker/supervisord.conf /etc/supervisor/conf.d/supervisord.conf
COPY ./docker/nginx.conf /etc/nginx/sites-available/default

RUN ln -s /etc/nginx/sites-available/default /etc/nginx/sites-enabled/default

# Define
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["mono", "MonoDemo.exe"]

