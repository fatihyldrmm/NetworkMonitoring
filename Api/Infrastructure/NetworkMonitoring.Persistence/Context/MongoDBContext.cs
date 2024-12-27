using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using NetworkMonitoring.Api.Persistence.MongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Persistence.Context
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:MongoDBConnection"];
            var databaseName = configuration["MongoDB:DatabaseName"];
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<SnmpSeriesData> SnmpData => _database.GetCollection<SnmpSeriesData>("SnmpData");
    }
}
