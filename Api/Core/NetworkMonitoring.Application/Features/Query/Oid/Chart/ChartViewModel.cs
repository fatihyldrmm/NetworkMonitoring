using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Application.Features.Query.Oid.Chart
{
    public class ChartViewModel
    {
        public List<ChartSeries> Series { get; set; }
        public List<string> Categories { get; set; }
    }

    public class ChartSeries
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
        public string Color { get; set; }
    }

}
