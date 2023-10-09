### How to spin up docker compose file

1. In shell/command prompt , Navigate to folder where `docker-compose.yaml` file is located 
2. Run docker compose command : `docker-compose up --build`
3. This will do the magic written in `Dockerfile` and `Makefile`.
4. Refer to `Dockerfile` and `Makefile` if you need more details
5. You will see some output like following which is building image.

![image](https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/89f528ec-71ec-465f-a8a6-5254733e991a)

4. Once images are build , it will spin up the project which will execute make file which in turns executed efbundle command.
   
![image](https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/8e7b02d3-b9f1-4b19-a5b5-94cbd23dbfc6)

5. Once command is executed , you will output like this.

![image](https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/f09f2fad-01fb-4057-bf2d-7981dd9e196f)

6. To rollback migration , exec into pod and run following command :

` @./efbundle --connection $${ConnectionStrings__DatabaseConnection} $$previousmigname `

7. If your host and deployment server are diffrent OS type then you can aditionally mention `--target-runtime` parameter in command while creating bundle in docker file , like :
`dotnet ef migrations bundle --target-runtime alpine.3.18-x64 --force --self-contained  --verbose`



   
