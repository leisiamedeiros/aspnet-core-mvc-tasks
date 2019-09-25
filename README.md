# ASP.NET Core MVC

Crud Tasks with Entity Framework and SqlServer with Docker  

![application](/images/taskslive.gif)

# Pull the image using docker
You can use this application without must clone it using `docker pull` command. It's simple, just execute `$ docker pull docker.pkg.github.com/leisiamedeiros/aspnet-core-mvc-tasks/aspnetcoremvctasks:latest` and enjoy it! Or you can simply run the [docker-compose-pull.yml](docker-compose-pull.yml) file.


# Clone and UP

Clone this application, by terminal navigate to the root folder (where is this application) and just execute `docker-compose build`. After that, execute `docker-compose up` and done! Or you can execute `docker-compose up --build` this will execute both tasks.

Theses commands will start the tasks application and it will be disponible on `localhost:5000`.

# Running Only MSSQL Container

The docker-compose is on `./Docker/compose-mssql/docker-compose.yml` to run it navigate to this folder and run the command `docker-compose up -d`. This command will run the service mssql and it will be avaliable on the port specified.
To more informations see the [Documentation](https://hub.docker.com/_/microsoft-mssql-server).

# Running Application on Local Environment

Before run the application you must create database name configured on ConnectionStrings and run the command `dotnet ef database update` to run the migrations on the database.  

To run the application, you need just run the command `dotnet run`.