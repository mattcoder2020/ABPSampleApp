# Stage 1: Build Angular Application
FROM node:16 AS angular-build
WORKDIR /app

# Copy the Angular client source code to the container
COPY angular/ ./

# Install dependencies and build Angular app
RUN npm install
RUN npm run build

# Stage 2: Build and publish .NET Application
FROM mcr.microsoft.com/dotnet/sdk:7 AS dotnet-build
WORKDIR /src

# Copy the ABP Framework solution to the container
COPY aspnet-core/ ./
#COPY ABPFrameworkApp/ ./ABPFrameworkApp/
#COPY ABPFrameworkApp.HttpApi.Host/ ./ABPFrameworkApp.HttpApi.Host/
#COPY ABPFrameworkApp.DbMigrator/ ./ABPFrameworkApp.DbMigrator/

# Restore and publish the .NET application
RUN dotnet restore
RUN dotnet publish -c Release -o /app

# Stage 3: Create the final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7 AS final
WORKDIR /app

# Copy the published .NET application from the previous stage
COPY --from=dotnet-build /app ./

# Copy the Angular build from the previous stage
COPY --from=angular-build /app/dist ./wwwroot

# Expose the ports used by the application
EXPOSE 44357 4200

# Set the entrypoint to run the database migrations, httpapi.host, and start the Angular app
ENTRYPOINT ["dotnet", "AbpSampleApp.AccessManagment.DbMigrator.exe"]
CMD ["&&", "dotnet", "AbpSampleApp.AccessManagment.HttpApi.Host.dll"]
#CMD ["&&", "dotnet", "ABPFrameworkApp.dll"]

# Add a script to start the Angular app using ng serve
CMD ["sh", "-c", "cd wwwroot && npx http-server -p 4200 & cd /wwwroot && ng serve --host 0.0.0.0"]
