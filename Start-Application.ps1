param( 
    [string] $Path = $(throw "Path is required."),
	[string] $Port = $(throw "Port is required.")
)
Get-Process | where { $_.ProcessName -like "IISExpress" } | Stop-Process
$IISExpressExe = '"c:\Program Files (x86)\IIS Express\iisexpress.exe"'
$Path = Resolve-Path $Path
$Params = "/path:$Path /port:$Port"
Write-Host $Params
$Command = "$IISExpressExe $Params"
Write-Host  $Command
Write-Host "Press Enter to continue"
Read-Host
Start-Process "$IISExpressExe" -ArgumentList "$Params"
Start-Sleep -m 1000
Write-Host "Site started"