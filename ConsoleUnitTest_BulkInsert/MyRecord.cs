using System;

using System.Data;

using System.Configuration;

namespace ConsoleUnitTest_BulkInsert
{
    /// <summary>

    /// Summary description for MyRecord

    /// </summary>

    public class MyRecord
    {
        public string Client;
        public string Job;
        public string AssetId;
        public string Component;
        public string ComponentId;

        public MyRecord()
        {

        }

        public MyRecord(string client, string job, string assetId, string component)
        {
            Client = client;
            Job = job;
            AssetId = assetId;
            Component = component;
        }

        public MyRecord(string client, string job, string assetId, string component,string componentId)
        {
            Client = client;
            Job = job;
            AssetId = assetId;
            Component = component;
            ComponentId = componentId;
        }
    }
}
