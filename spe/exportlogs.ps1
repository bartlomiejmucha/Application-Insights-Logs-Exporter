# AILogsExporter v0.3.1 (SPE)
# https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter

$result = Read-Variable -Parameters `
    @{ Name = "applicationId"; Value=""; Title="Application Id"}, 
    @{ Name = "apiKey"; Value=""; Title="Api Key"}, 
    @{ Name = "query"; Value='traces | where timestamp > ago(1d) | extend line=strcat(format_datetime(timestamp,"yyyy-MM-dd"),"|",message)'; Title="Query"; lines=3},
    @{ Name = "batchSize"; Value=500000; Title="Batch Size" },
    @{ Name = "insertBatchNumberLine"; Value=$false; Title="Insert Batch Number Line"},
    @{ Name = "exportAllBatches"; Value=$true; Title="Export All Batches"} `
    -Description "https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter" `
    -Title "AILogsExporter v0.3.1" -Width 600 -Height 600 -OkButtonName "Export" -CancelButtonName "Cancel" -ShowHints
    
if($result -ne "ok")
{
    Exit
}

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

try 
{  
    $logFilePath = "$($SitecoreDataFolder)\traces.log"
    $retryCount = 3
    
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
    $batchNumber = 1
    
    do
    {
        $finalQuery = $query
        if ($lastTimeStamp -ne $null)
        {
            $finalQuery = "$query | where timestamp >= datetime($lastTimeStamp)"
        }
        
        $finalQuery = "$finalQuery | top $batchSize by timestamp asc | project timestamp, line"
        $finalQuery = [System.Uri]::EscapeDataString($finalQuery)
        
        Write-Host "Requesting a log batch #$batchNumber"
        
        $response =(GetAsyncWithRetry $client "https://api.applicationinsights.io/v1/apps/$applicationId/query?query=$finalQuery" $retryCount)
        if ($response.IsSuccessStatusCode)
        {
            $responseContent = $response.Content.ReadAsStringAsync().Result | ConvertFrom-Json
            if ($responseContent.error -ne $null)
            {
                Show-Alert -Title (ConvertTo-Json $responseContent.error)
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
                    Show-Alert -Title (ConvertTo-Json $responseContent.error)
                    break
                }
            }
            
            Show-Alert -Title $response
        }
        
        $batchNumber++
    } 
    while ($exportAllBatches -and $response.IsSuccessStatusCode -and $lines.Count -ge $batchSize)
    
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