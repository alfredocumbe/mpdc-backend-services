## Passos para instalação dos serviços de backend

#### Pré-requisitos
     Garantir que a maquina tenha acesso a internet e tenha o docker devidamente instalado e configurado

1. Criar uma rede docker
  ```sh
  docker network create mpdc
  ```

2. criar a base de dados
  ```sh
  docker volume create sqlserver01
  docker run --network mpdc -e "ACCEPT_EULA=Y" -e MSSQL_SA_PASSWORD=SsMs#P@ssw0rd2023!  --name sqlserver01 -v sqlserver01:/var/opt/mssql -p 1533:1433  -d mcr.microsoft.com/mssql/server:2022-latest
  ```

3. Connectar a base de dados criada no ponto 2 e executar o script do ficheiro "db-schema.sql"


4. Criar a imagem da webapi
  ```sh
  docker build -t mpdc-backend-services .
  ```

5. Correr o container da webapi
  ```sh
  docker run --network mpdc  --name backend-services01 -p 7272:80 -d mpdc-backend-services:latest
  ```

6. O serviço estará exposto a seguinte e endereço https://localhost:7272
