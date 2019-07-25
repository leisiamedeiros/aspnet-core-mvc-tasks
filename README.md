# ASP.NET Core MVC

Crud Tasks with Entity Framework and SqlServer with Docker

# Running MSSQL Container

The docker-compose is on `./Docker/compose-mssql/docker-compose.yml` to run it navigate to this folder and run the command `docker-compose up -d`. This command will run the service mssql and it will be avaliable on the port specified.
To more informations see the [Documentation](https://hub.docker.com/_/microsoft-mssql-server).

# Running the Application

Before run the application you must create database name configured on ConnectionStrings and run the command `dotnet ef database update` to run the migrations on the database.  

To run the application, you need just run the command `dotnet run`.