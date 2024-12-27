using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Persistence.MongoDB.Models
{
    public class SnmpDataPoint
    {
        [BsonElement("value")]
        public object Value { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonElement("timestamp")]
        public DateTime TimeStamp { get; set; }
    }

    public class SnmpSeries
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("data")]
        public List<SnmpDataPoint> Data { get; set; } = new List<SnmpDataPoint>();

        [BsonElement("color")]
        public string Color { get; set; }
    }

    public class SnmpSeriesData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("series")]
        public List<SnmpSeries> Series { get; set; } = new List<SnmpSeries>();
    }
}
