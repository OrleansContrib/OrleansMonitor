using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Net;
using System.Text;

namespace Two10.OrleansMonitor
{
    public class SiloMetricsTable : TableEntity
    {
        public string DeploymentId { get; set; }

        public string Address { get; set; }

        public string SiloName { get; set; }

        public string GatewayAddress { get; set; }

        public string HostName { get; set; }

        public double CPU { get; set; }

        public long MemoryUsage { get; set; }

        public int Activations { get; set; }

        public int SendQueue { get; set; }

        public int ReceiveQueue { get; set; }

        public long RequestQueue { get; set; }

        public long SentMessages { get; set; }

        public long ReceivedMessages { get; set; }

        public bool LoadShedding { get; set; }

        public long ClientCount { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("OrleansSiloMetricsData[");
            stringBuilder.Append(" PartitionKey=").Append(this.PartitionKey);
            stringBuilder.Append(" RowKey=").Append(this.RowKey);
            stringBuilder.Append(" DeploymentId=").Append(this.DeploymentId);
            stringBuilder.Append(" Address=").Append(this.Address);
            stringBuilder.Append(" SiloName=").Append(this.SiloName);
            stringBuilder.Append(" GatewayAddress=").Append(this.GatewayAddress);
            stringBuilder.Append(" HostName=").Append(this.HostName);
            stringBuilder.Append(" CPU=").Append(this.CPU);
            stringBuilder.Append(" MemoryUsage=").Append(this.MemoryUsage);
            stringBuilder.Append(" Activations=").Append(this.Activations);
            stringBuilder.Append(" SendQueue=").Append(this.SendQueue);
            stringBuilder.Append(" ReceiveQueue=").Append(this.ReceiveQueue);
            stringBuilder.Append(" RequestQueue=").Append(this.RequestQueue);
            stringBuilder.Append(" SentMessages=").Append(this.SentMessages);
            stringBuilder.Append(" ReceivedMessages=").Append(this.ReceivedMessages);
            stringBuilder.Append(" LoadShedding=").Append(this.LoadShedding);
            stringBuilder.Append(" Clients=").Append(this.ClientCount);
            stringBuilder.Append(" ]");
            return stringBuilder.ToString();
        }
    }
}
