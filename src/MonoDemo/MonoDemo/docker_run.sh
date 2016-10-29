#!/bin/bash

docker run --name monodemo -d -p 8888:80 efaruk/dotnet:monodemo
docker ps
