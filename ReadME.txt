Setup and run angular app
1. install node-v16(or greater, my install is v18) at your windows server
2. navgiate to angular subfolder, and execute "npm install -g @angular/cli"
3. navgiate to angular subfolder, and execute "ng serve"

Setup and run Abpframework app
1. install .net7 framework at your local desktop
2. install docker desktop at your local desktop 
3. navigate to subfolder /docker
4. run command "docker-compose -f docker-compose-3party.yml up" to kick start the mysql instance
5. navigate to subfolder /aspnet-core\src\AbpSampleApp.AccessManagment.DbMigrator
6. run command "dotnet run" to seend the mysql with preliminary set of db records
7. navigate to subfolder \aspnet-core\src\AbpSampleApp.AccessManagment.HttpApi.Host
8. run command "dotnet run" to kick start the swaggerui 

Finally open your web browser and navigate to http://localhost:4200 to access the UI.

 