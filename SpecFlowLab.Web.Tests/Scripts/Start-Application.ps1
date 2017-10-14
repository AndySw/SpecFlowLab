param( 
    [string] $path = $(throw "Path is required."),
	[string] $port = $(throw "Port is required.")
)
Get-Process | where { $_.ProcessName -like "IISExpress" } | Stop-Process
$iisExpressExe = '`"c:\Program Files (x86)\IIS Express\iisexpress.exe`"'
$path = Resolve-Path $path
$params = "/path:`"$path`" /port:$port"
Write-Host $params
Write-Host "Press Enter to continue"
Read-Host
cmd /c start cmd /k "$iisExpressExe $params"
Start-Sleep -m 1000
Write-Host "Site started"