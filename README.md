
# Setup

Skapa en användare i Azure Data Studio och använd den i connectionsträngen i Context.cs ( Kopiera den från det här projektet och ändra det som behöver ändras om du vill )

Om det är första gången du jobbar med entity framework på din dator, kör 'dotnet tool install -g dotnet-ef --version 7.0.14' i din terminal/package manager console

1. Installera nuget-paket genom "Manage Nuget Packages" i Visual Stuio, eller genom 
	att klistra in följande i Package Manager Console ( Om ni kör .NET 8 ska siffrorna istället vara 8.0.0 ): 
		Install-Package Microsoft.EntityFrameworkCore -Version 7.0.14
		Install-Package Microsoft.EntityFrameworkCore.Design -Version 7.0.14
		Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.14
2. Skapa en mapp som heter Models, och i den klasserna Car/RentalOffice/Customer med tillhörande properties
3. Skapa en mapp som heter Data, och skapa i den en fil som heter Context.cs
4. Lägg till DbSet för klasserna ovan i Context.cs
5. Skapa DataAccess.cs i Data-mappen och lägg till metoder för att skapa/återställa databasen samt skriva/läsa data

# Modifiera befintligt projekt

1. Följ stegen ovan
2. Bestäm vilken data som ska sparas i databasen, alla klasser måste inte finnas med där
3. Modifiera en befintlig klass eller lägg till en ny för att hålla ordning på datan som ska sparas
4. Lägg till klassen som ska sparas i en DbSet i Context.cs

# Migration / Database Update / Build

The purpose of a migration is to create the database schema (tables/columns etc.)
for our database. Which database to update is controlled by the connection string in 
our Context class. If we do not want to use migrations, we will need to manually create
and/or change the database schema.

Entity Framework creates the database schema/definition from the information given
in Context.cs. A migration-file contains the information needed about changes to make
to the database, this can be new columns/tables/restrictions etc.

Creating the migration-file does not change the database, that is done when we run the 
`dotnet ef database update` command. 

1. For our migrations to work properly we need to make sure of these things:
	- Our code changes are saved
	- Our Context contains the DbSets needed if we have created new 
	   classes that we want to save in the database
	- Our code builds without errors
2. We need to make a new migration when we have made changes to the 
    structure of our database, either by adding new properties to existing classes or 
    adding new classes altogether.
3. If our `dotnet ef migrations add migrationNameHere` command fails, go to step 1.
4. To push the changes in the migration to the database, run `dotnet ef database update`

