# AILogsExporter v0.1 (SPE)
# https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter
$result = Read-Variable -Parameters `
    @{ Name = "applicationId"; Value=""; Title="Application Id"}, 
    @{ Name = "apiKey"; Value=""; Title="Api Key"}, 
    @{ Name = "startDateTime"; Value=[System.DateTime]::Now.AddDays(-1); Title="Start Date Time (Local)"; Editor="date time"}, 
    @{ Name = "endDateTime"; Value=[System.DateTime]::Now; Title="End Date Time (Local)"; Editor="date time"} `
    -Description "https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter" `
    -Title "AILogsExporter v0.1" -Width 600 -Height 400 -OkButtonName "Export" -CancelButtonName "Cancel" -ShowHints
    
if($result -ne "ok")
{
    Exit
}

try 
{  
    $logFilePath = "$($SitecoreDataFolder)\traces.log"
    $startTimestampUtc = $startDateTime.ToUniversalTime().ToString("O")
    $endTimestampUtc = $endDateTime.ToUniversalTime().ToString("O")
    
    $client = New-Object System.Net.Http.HttpClient
    $client.DefaultRequestHeaders.Add("x-api-key", $apiKey)
    $client.Timeout = New-TimeSpan -Minutes 10
    
    if ([System.IO.File]::Exists($logFilePath))
    {
        [System.IO.File]::Delete($logFilePath)
    }

    $response = $null;
    $lines = $null;

    do
    {
        $path = "http://api.applicationinsights.io/v1/apps/$applicationId/query?query=traces|where timestamp >= datetime($startTimestampUtc) and timestamp <= datetime($endTimestampUtc)|project timestamp, message|order by timestamp asc";

        $response = $client.GetAsync($path).Result
        if ($response.IsSuccessStatusCode)
        {
            $resultObject = $response.Content.ReadAsStringAsync().Result | ConvertFrom-Json
            $lines = $resultObject.tables[0].rows
            if ($lines.Count -gt 0)
            {
                [Collections.Generic.List[String]]$linesAsString = foreach ($line in $lines) { $line[0] + "|" + $line[1] }
                [System.IO.File]::AppendAllLines($logFilePath, $linesAsString)

                $startTimestampUtc = $lines[-1][0]
            }
        }
        else 
        {
            Show-Alert -Title $response
        }
    } while ($response.IsSuccessStatusCode -and $lines -ne $null -and $lines.Count -ge 500000)
    
    if ($response.IsSuccessStatusCode)
    {
        Download-File -FullName $logFilePath > $null
    }
    
    if ([System.IO.File]::Exists($logFilePath))
    {
        [System.IO.File]::Delete($logFilePath)
    }
}
catch {
    Show-Alert -Title $_.Exception
}