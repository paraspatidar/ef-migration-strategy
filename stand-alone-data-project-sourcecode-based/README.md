1. In shell/command prompt , Navigate to folder where docker-compose.yaml file is located
2. Run docker compose command : docker-compose up --build
3. This will do the magic written in `Dockerfile` and `Makefile`.
4. Refer to `Dockerfile` and `Makefile` if you need more details
5. You will see some output like following which is building image.

![image](https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/449916f9-8913-46c2-a044-edc4f1dff051)

6. If you will see inside pod by doing `exec` , you will be able to see all source code files.

![image](https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/32d0fead-fb6c-4f05-89a6-ebb683c6ea91)

7. As `dotnet ef tools` are added in docker image and are in project , thus you can run the dotnet ef tool command like `rollback` , `update-database` etc.
