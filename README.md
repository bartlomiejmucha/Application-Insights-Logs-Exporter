# Application-Insights-Logs-Exporter
A tool to export logs from Application Insights.

Tool has three versions:
* Standalone
* Window PowerShell
* Sitecore PowerShell Extension

# Installation and Usage
To use the tool you have to generate REST API Key. Here is a [link to a documentation](https://dev.applicationinsights.io/documentation/Authorization/API-key-and-App-ID) where you can read how to do it.

## Standalone
To use a standalone version, go to the [releases page](https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter/releases) and download standalone version of the tool, unzip it and then execute AILogsExporter.exe file, provide settings and click Export.
 
![Standalone application image](https://raw.githubusercontent.com/bartlomiejmucha/Application-Insights-Logs-Exporter/master/images/standalone.jpg "Standalone application image")

## Windows PowerShell
To use the windows powershell version, go to the [releases page](https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter/releases) and download powershell version of the tool, open it in text editor, provide parameters and then execute in Windows Powershell.

## Sitecore PowerShell Extension
To use the SPE version, go to the [releases page](https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter/releases) and download SPE version of the tool. Its a sitecore package that creates a new item `/sitecore/system/Modules/PowerShell/Script Library/SPE/Maintenance/System Maintenance/Tasks/Export Application Inisghts Logs`. 
Open PowerShell ISE in Sitecore, open script installed by the package and execute.

![SPE image](https://raw.githubusercontent.com/bartlomiejmucha/Application-Insights-Logs-Exporter/master/images/spe.jpg "SPE image")