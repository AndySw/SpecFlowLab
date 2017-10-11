$iisExpressExe = '"C:\Program Files (x86)\IIS Express\iisexpress.exe"'
$path = "C:\Users\andrew.sweetman\Projects\github\SpecFlowLab\.vs\config\applicationhost.config"
$site = "SpecFlowLab.Web"
$apppool = "Clr4IntegratedAppPool"
$params = "/config:$path /site:$site"
Write-Host Get-Location
Get-Process | where { $_.ProcessName -like "IISExpress" } | Stop-Process
Start-Process -FilePath $iisExpressExe -ArgumentList $params