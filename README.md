Migration / Database Update / Build

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

