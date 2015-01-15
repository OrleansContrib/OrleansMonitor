using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two10.OrleansMonitor
{
    public class OrleansMonitorClient
    {
        public CloudTableClient TableClient { get; private set; }

        public OrleansMonitorClient(CloudTableClient tableClient)
        {
            if (null == tableClient) throw new ArgumentNullException("tableClient");
            this.TableClient = tableClient;
        }

        public IEnumerable<SiloMetricsTable> QuerySiloMetrics(string deploymentId)
        {
            var table = this.TableClient.GetTableReference("OrleansSiloMetrics");
            var query = new TableQuery<SiloMetricsTable>();
            query.Where(TableQuery.GenerateFilterCondition("PartitionKey", "eq", deploymentId));
            return table.ExecuteQuery(query);
        }

    }
}
