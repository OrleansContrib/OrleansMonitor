# Orleans Monitor

[![Build Status](https://travis-ci.org/OrleansContrib/OrleansMonitor.svg)](https://travis-ci.org/OrleansContrib/OrleansMonitor)

Use this library to monitor the Silos in your Orleans Deployment.

## Installation

Install using the [nuget package](https://www.nuget.org/packages/Two10.OrleansMonitor).

```
PM> Install-Package Two10.OrleansMonitor
```

## Usage

```c#
// start with the Azure storage account you're using to monitor Orleans
var azureStorageAccount = CloudStorageAccount.Parse("UseDevelopmentStorage=true");

// create an OrleansMonitorClient
var orleansMonitorClient = azureStorageAccount.CreateOrleansMonitorClient();

// query the silo metrics for a given deployment
var siloMetrics = orleansMonitorClient.QuerySiloMetrics("deploymentId")

foreach (var silo in siloMetrics)
{
	Console.WriteLine("Activations: {0}", silo.Activations);
	Console.WriteLine("RequestQueue: {0}", silo.RequestQueue);
	Console.WriteLine("CPU: {0}", silo.CPU);
	// etc...
}

```

## License 

MIT