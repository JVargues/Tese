Param (
	[string]$migrationFromName,
	[string]$migrationToName,
	[switch]$verbose
)

$migrationProjectName = "Domain"
$startupProjectName = "Domain"
#$contextName = "Context"
#$migrationFromName = Read-Host -Prompt 'Input From Migration Name (optional)'
#$migrationToName = Read-Host -Prompt 'Input To Migration Name (optional)'

if([string]::IsNullOrEmpty($migrationFromName)){
	 if($verbose){
        Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationMigrationScripts\FullDatabase.sql"
    }		
	else{
	    Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationScripts\FullDatabase.sql"
    }		
} 
elseif([string]::IsNullOrEmpty($migrationToName)){
    if($verbose){
        Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationScripts\$($migrationFromName).sql" -From $migrationFromName -Verbose
    }		
	else{
	    Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationScripts\$($migrationFromName).sql" -From $migrationFromName
    }	
}	
else{
	if($verbose){
		Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationScripts\$($migrationFromName)_$($migrationToName).sql" -From $migrationFromName -To $migrationToName -Verbose
    }
	else{
		Script-Migration -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Output "..\MigrationScripts\$($migrationFromName)_$($migrationToName).sql" -From $migrationFromName -To $migrationToName
    }
}