FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS builder
WORKDIR /app
COPY . .
RUN dotnet tool restore
COPY *.csproj .
RUN dotnet restore
COPY . .

RUN apk add make

# Install dotnet tools
ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef  --version 7.0.0

# Create bundle of current project , thats sort of compiled bundled
# in case build OS is diffrent then target deployment OS then consider giving aditional param e.g
# dotnet ef migrations bundle -v --force  --target-runtime alpine-x64 --self-contained
RUN dotnet ef migrations bundle -v --force

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /app
RUN apk add make
COPY --from=builder /app/efbundle .
COPY --from=builder /app/Makefile .
ENTRYPOINT [ "make" ]
CMD [ "update" ]
