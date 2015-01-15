using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Storage;
using System.Linq;
using System.Collections.Generic;


namespace Two10.OrleansMonitor.UnitTests
{
    [TestClass]
    public class LocalTests
    {
        [TestMethod]
        public void TestMyActiveDeployment()
        {
            var cloudStorageAccount = CloudStorageAccount.DevelopmentStorageAccount;
            var orleansMonitorClient = cloudStorageAccount.CreateOrleansMonitorClient();
            var results = orleansMonitorClient.QuerySiloMetrics("deployment24(54)").ToArray();
            Assert.AreEqual(results.Length, 1);
            Assert.AreEqual(results[0].Activations, 0);
            Assert.IsNotNull(results[0].ToString());
        }

        [TestMethod]
        public void TestNonExistantDeployment()
        {
            var cloudStorageAccount = CloudStorageAccount.DevelopmentStorageAccount;
            var orleansMonitorClient = cloudStorageAccount.CreateOrleansMonitorClient();
            var results = orleansMonitorClient.QuerySiloMetrics("XXX").ToArray();
            Assert.AreEqual(results.Length, 0);
        }

    }
}
