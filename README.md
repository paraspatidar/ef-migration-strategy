### Ef core migration demo

This repo contains 3 diffrence type of varities on how someone can migrate and update the database based on  the ef / efocre based contexts and entities.
Three aproaches mentioned here are : 


| Project Sample  | Description |
|------------- | -------------|
|stand-alone-data-project-sourcecode-based  | standard old school way of copying all source files and then running ef tool commands|
|stand-alone-data-project-customapp-based  | customer application which reated a docker image which as soon as starts , does the data migration|
|**stand-alone-data-project-efbundle-based**  | The devops friendly *best way *where migration bundle is created and it gets deployed which doest the job.|

Each inidivusual folder has its own docker compose file , source code and docker file.
Docker compose build the project , creates docker image and then spin up the container.
if you are making changes to source code , please dont forget to refresh image or rebuild image when running docker compose via `docker-compose up --build`

Rest of the details and steps are as per each type of project and can be seen inside project's readme file.

### Postgresql
This samples uses postgresql for illustration purpose (as ef core is compatible not just with mssql but various other dbs )
Thus the docker compose file contains the postgre db as well as its UI tool (pg admin) docker images.

| Resource   | Running on  |
|------------- | -------------|
|postgressql db  |http://localhost:5435|
|pg admin web  | http://localhost:5050|


##### Steps to connect to pg admin to view DB changes 

1. Open PG admin web( http://localhost:5050)
2. On Main Web UI use credentials mentioned in docker compose file i.e username/email as  `admin@admin.com` and password as `root`.
<kbd>
<img src="https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/c5030ba7-bf6e-4d3d-8bd6-e88b97daf2bd" data-canonical-src="https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/c5030ba7-bf6e-4d3d-8bd6-e88b97daf2bd" width="500" height="400" style="vertical-align:middle;margin:0px 200px" />
 </kbd>

3. Now , once inside the portal , connect to locally running postgresql by providing the container name(as db) and other details as per docker compose file i.e username `postgres` and password as `postgres`.

<kbd>
<img src="https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/60badd9a-6438-4ff4-9210-1e99bd72fae2" data-canonical-src="https://github.com/paraspatidar/ef-migration-strategy/assets/5575617/60badd9a-6438-4ff4-9210-1e99bd72fae2" width="500" height="400" style="vertical-align:middle;margin:0px 200px" />
 </kbd>

4. connect to db , expand as per image and reach till schemas --> tables and you will be able to view tables and schemas.
