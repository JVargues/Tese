Param (
	[string]$migrationName,
	[switch]$verbose
)

$migrationProjectName = "Domain"
$startupProjectName = "Domain"
#$contextName = "Context"
#$migrationName = Read-Host -Prompt 'Input Target Migration Name'

if($verbose){
	Update-Database $migrationName -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Verbose
	}
else{
	Update-Database $migrationName -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#>
}