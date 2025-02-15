﻿namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public class SnmpDataPoint
    {
        public string OidName { get; set; }
        public string OidValue { get; set; }
        public DateTime TimeStamp { get; set; }
    }
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
