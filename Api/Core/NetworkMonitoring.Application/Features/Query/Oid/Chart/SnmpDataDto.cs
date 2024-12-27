using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Application.Features.Query.Oid.Chart
{
    public class SnmpDataDto
    {
        public string Oid { get; set; }
        public List<SnmpDataPoint> DataPoints { get; set; }
    }

    public class SnmpDataPoint
    {
        public DateTime Timestamp { get; set; }
        public int Value { get; set; }
    }

}
