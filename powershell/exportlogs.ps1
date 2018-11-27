#AILogsExporter (Powershell version) by https://bartlomiejmucha.com, v0.1 beta
Add-Type -AssemblyName System.Net.Http

$applicationId = ""
$apiKey = ""
$startTimestampUtc = "2018-11-27T08:00:00"
$endTimestampUtc = "2018-11-27T09:00:00"
$logFilePath = "C:\traces.log"

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
            Write-Host "Error: $response"
        }
    } while ($response.IsSuccessStatusCode -and $lines -ne $null -and $lines.Count -ge 500000)
}
catch {
    Write-Host "Error: " + $_.Exception
}