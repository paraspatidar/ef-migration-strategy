### How to spin up docker compose file

1. In shell/command prompt , Navigate to folder where `docker-compose.yaml` file is located 
2. Run docker compose command : `docker-compose up --build`
3. This will do the magic written in `Dockerfile` and `Makefile`.
4. Refer to `Dockerfile` and `Makefile` if you need more details
5. This will create a compiled project dll as usual.
6. As soon as docker image will start that console app/dll wil be invocked which will do data migration as its written in startup code.
7. As no project or bundle is there thus can not run usual `dotnet ef tools` based commands,




   
