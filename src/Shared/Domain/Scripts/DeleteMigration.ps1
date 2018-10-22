Param (
	<#[string]$migrationName,#>
	[switch]$verbose
)

$migrationProjectName = "Domain"
$startupProjectName = "Domain"
#$contextName = "Context"
#$migrationName = Read-Host -Prompt 'Input Migration Name'

if($verbose){
	Remove-Migration <#$migrationName#> -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#> -Verbose
}else{
	Remove-Migration <#$migrationName#> -Project $migrationProjectName -StartupProject $startupProjectName <#-Context $contextName#>
}