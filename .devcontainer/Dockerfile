# Devcontainer for .NET 8 and Jaeger
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base

# Install Docker CLI (for docker-in-docker, optional)
RUN apt-get update && apt-get install -y docker.io

# Install Jaeger all-in-one
RUN apt-get update && apt-get install -y wget && \
    wget -O /usr/local/bin/jaeger-all-in-one https://github.com/jaegertracing/jaeger/releases/download/v1.57.0/jaeger-1.57.0-linux-amd64.tar.gz && \
    tar -xzf /usr/local/bin/jaeger-all-in-one -C /usr/local/bin/ && \
    chmod +x /usr/local/bin/jaeger-all-in-one || true

# Expose Jaeger UI and agent ports
EXPOSE 16686 6831 6832 5778 14268 14250 9411

# Entrypoint will be handled by devcontainer.json
