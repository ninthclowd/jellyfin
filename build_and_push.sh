#!/bin/sh
docker build --no-cache -t ninthclowd/jellyfin:latest .
docker push ninthclowd/jellyfin:latest

