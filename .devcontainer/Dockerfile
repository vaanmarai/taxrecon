# Devcontainer for .NET 8 and Jaeger
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base

# Clean apt cache and update, retry on failure, and use --fix-missing
RUN rm -rf /var/lib/apt/lists/* \
    && for i in 1 2 3; do apt-get update --allow-releaseinfo-change && break || sleep 5; done \
    && for i in 1 2 3; do apt-get install -y --fix-missing docker.io wget && break || sleep 5; done \
    && rm -rf /var/lib/apt/lists/*

# Install Jaeger all-in-one
RUN wget https://github.com/jaegertracing/jaeger/releases/download/v1.57.0/jaeger-1.57.0-linux-amd64.tar.gz \
    && tar -xzf jaeger-1.57.0-linux-amd64.tar.gz \
    && mv jaeger-1.57.0-linux-amd64/jaeger-all-in-one /usr/local/bin/jaeger-all-in-one \
    && chmod +x /usr/local/bin/jaeger-all-in-one \
    && rm -rf jaeger-1.57.0-linux-amd64*

# Expose Jaeger UI and agent ports
EXPOSE 16686 6831 6832 5778 14268 14250 9411

# Entrypoint will be handled by devcontainer.json
