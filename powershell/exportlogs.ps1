# AILogsExporter v0.3.1 (powershell)
# https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter
Add-Type -AssemblyName System.Net.Http

function GetAsyncWithRetry
{
    Param ([System.Net.Http.HttpClient]$client,[string]$requestUri,[int]$retryCount)

    $response = $null;
    for ($i = 0; $i -lt $retryCount; $i++)
    {
        $response = $client.GetAsync($requestUri).Result;
        if ($response.IsSuccessStatusCode)
        {
            return $response;
        }

        Write-Host "Retrying" ($i+1)
    }

    return $response;
}

$applicationId = ''
$apiKey = ''
$logFilePath = 'C:\traces.log'
$query = 'traces | where timestamp > ago(1d) | extend line = strcat(format_datetime(timestamp, "yyyy-MM-dd"),"|",message)'
$batchSize = 500000
$retryCount = 3
$insertBatchNumberLine = $false
$exportAllBatches = $true

try 
{  
    $client = New-Object System.Net.Http.HttpClient
    $client.DefaultRequestHeaders.Add('x-api-key', $apiKey)
    $client.Timeout = New-TimeSpan -Minutes 10

    if ([System.IO.File]::Exists($logFilePath))
    {
        [System.IO.File]::Delete($logFilePath)
    }

    $response = $null;
    $lines = $null;
    $lastTimeStamp = $null;
    $batchNumber = 1

    do
    {
        $finalQuery = $query;
        if ($lastTimeStamp -ne $null)
        {
            $finalQuery = "$query | where timestamp >= datetime($lastTimeStamp)"
        }

        $finalQuery = "$finalQuery | top $batchSize by timestamp asc | project timestamp, line"
        $finalQuery = [System.Uri]::EscapeDataString($finalQuery)

        Write-Host "Requesting a log batch #$batchNumber"

        $response = (GetAsyncWithRetry $client "https://api.applicationinsights.io/v1/apps/$applicationId/query?query=$finalQuery" $retryCount)
        if ($response.IsSuccessStatusCode)
        {
            $responseContent = $response.Content.ReadAsStringAsync().Result | ConvertFrom-Json
            if ($responseContent.error -ne $null)
            {
                Write-Host 'Error: ' (ConvertTo-Json $responseContent.error)
                break
            }

            $lines = $responseContent.tables[0].rows
            if ($lines.Count -gt 0)
            {
                if($insertBatchNumberLine)
                {
                    [System.IO.File]::AppendAllText($logFilePath, "-- BATCH $batchNumber`n");
                }

                [Collections.Generic.List[String]]$linesAsString = foreach ($line in $lines) { $line[1] }
                [System.IO.File]::AppendAllLines($logFilePath, $linesAsString)

                $lastTimeStamp = $lines[-1][0]
            }
        }
        else 
        {
            if ($response.Content -ne $null)
            {
                $responseContent = $response.Content.ReadAsStringAsync().Result | ConvertFrom-Json
                if ($responseContent.error -ne $null)
                {
                    Write-Host 'Error: ' (ConvertTo-Json $responseContent.error)
                    break
                }
            }

            Write-Host "Error: $response"
            break;
        }

        $batchNumber++
    } 
    while ($exportAllBatches -and $response.IsSuccessStatusCode -and $lines.Count -ge $batchSize)
}
catch 
{
    Write-Host 'Error: ' + $_.Exception
}