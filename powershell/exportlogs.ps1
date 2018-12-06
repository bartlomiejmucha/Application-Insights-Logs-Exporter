# AILogsExporter v0.2 (powershell)
# https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter
Add-Type -AssemblyName System.Net.Http

$applicationId = ""
$apiKey = ""
$logFilePath = "C:\traces.log"
$query = "traces | where timestamp > ago(4d) | extend line = message"

try 
{  
    $client = New-Object System.Net.Http.HttpClient
    $client.DefaultRequestHeaders.Add("x-api-key", $apiKey)
    $client.Timeout = New-TimeSpan -Minutes 10

    if ([System.IO.File]::Exists($logFilePath))
    {
        [System.IO.File]::Delete($logFilePath)
    }

    $response = $null;
    $lines = $null;
    $lastTimeStamp = $null;

    do
    {
        $finalQuery = $query;
        if ($lastTimeStamp -ne $null)
        {
            $finalQuery = "$query|where timestamp >= datetime($lastTimeStamp)"
        }

        $finalQuery = "$finalQuery|order by timestamp asc|project timestamp, line"

        $response = $client.GetAsync("http://api.applicationinsights.io/v1/apps/$applicationId/query?query=$finalQuery").Result
        if ($response.IsSuccessStatusCode)
        {
            $resultObject = $response.Content.ReadAsStringAsync().Result | ConvertFrom-Json
            $lines = $resultObject.tables[0].rows
            if ($lines.Count -gt 0)
            {
                [Collections.Generic.List[String]]$linesAsString = foreach ($line in $lines) { $line[1] }
                [System.IO.File]::AppendAllLines($logFilePath, $linesAsString)

                $lastTimeStamp = $lines[-1][0]
            }
        }
        else 
        {
            Write-Host "Error: $response"
        }
    } while ($response.IsSuccessStatusCode -and $lines -ne $null -and $lines.Count -ge 500000)
}
catch {
    Write-Host "Error: " + $_.Exception
}