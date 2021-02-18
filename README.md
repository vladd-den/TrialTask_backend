# Trial task backend part

## Getting Started
In order to run the project you need to configure localhost port, or you can leave it by default value.

1. Grab the Project.
2. Open Visual Studio and load the Solution.
3. Resolve any missing/required nuget package.
4. Change your connection string in the appsettings.json.
5. Make migration using next commands in the NuGet package manager console
- Add-Migration "*Name of your migration here*"
- Update-Database
6. Now you are free to run the project.

## Additional

You need to fill the database manually using services for managing the databases, for example Microsoft Managment Studio.