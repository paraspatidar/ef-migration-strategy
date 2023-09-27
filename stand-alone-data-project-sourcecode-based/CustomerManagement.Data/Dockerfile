FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine
RUN apk add make


ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef  --version 7.0.0

WORKDIR /src/CustomerManagement.Data/CustomerManagement.Data
COPY . .

ENTRYPOINT [ "make" ]
CMD [ "update" ]
