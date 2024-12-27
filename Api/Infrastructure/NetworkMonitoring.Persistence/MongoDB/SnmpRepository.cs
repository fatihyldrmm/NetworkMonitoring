using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using NetworkMonitoring.Api.Persistence.MongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Persistence.MongoDB
{
    public class SnmpRepository
    {
        private readonly IMongoCollection<SnmpSeriesData> _collection;

        public SnmpRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["ConnectionStrings:MongoDBConnection"]);
            var database = client.GetDatabase("NetworkMonitoringMongoDB");
            _collection = database.GetCollection<SnmpSeriesData>("SnmpData");
        }

        public async Task<List<SnmpSeriesData>> GetAllDataAsync()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }
    }
}
