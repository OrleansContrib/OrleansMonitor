using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Two10.OrleansMonitor;

namespace Microsoft.WindowsAzure.Storage
{
    public static class CloudStorageAccountExtensions
    {

        // patch the 'CreateOrleansMonitorClient' method on to the CloudStorageAccount
        public static OrleansMonitorClient CreateOrleansMonitorClient(this CloudStorageAccount account)
        {
            if (null == account) throw new ArgumentNullException("account");

            return new OrleansMonitorClient(account.CreateCloudTableClient());        
        }


    }
}
