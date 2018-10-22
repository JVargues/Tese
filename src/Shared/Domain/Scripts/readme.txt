-> Install Migrations tools in Project:

Nuget Package - Microsoft.EntityFrameworkCore.Tools

-> Usage for PowerShell scripts:

1 - Change directory in Package Manager Console (PMC), so it can run the scripts in appropriate folder:
PM> cd src\Shared\Domain\Scripts

Scripts to Run:

1 - CreateMigration.ps1
This script creates a migration with the differences between last migration and the modified model. 
If it's the first run it will just create the script to script the creation of all objects necessary 
to create a database from the scratch.

USAGE: .\CreateMigration.ps1 <MigrationName> -Verbose (if you want to log all actions)
INPUT PARAMETER: <MigrationName> Name of the migration to create.

2 - DeleteMigration.ps1
This script deletes the migration created before. 

USAGE: .\DeleteMigration.ps1 <MigrationName> -Verbose (if you want to log all actions)
INPUT PARAMETER: <MigrationName> Name of the migration to delete.

3 - UpdateDatabase.ps1
This script alters the database to the target Migration based on connection string configured 
in SourceProject (Domain). 

USAGE: .\UpdateDatabase.ps1 <MigrationName> -Verbose (if you want to log all actions)
INPUT PARAMETER: <MigrationName> Name of the target migration to modify the database.

4 - CreateScripts.ps1
This script creates the SQL scripts between two migrations or for all the database. If no migrations 
were provided in input, the generated script will be of all existing migrations. The scripts are generated
in \Scripts folder of the current project.

USAGE: .\CreateScripts.ps1 <SourceMigrationName> <TargetMigrationName> -Verbose (if you want to log all actions)
INPUT PARAMETER: <SourceMigrationName> Name of the source migration (optional).
INPUT PARAMETER: <TargetMigrationName> Name of the target migration (optional).