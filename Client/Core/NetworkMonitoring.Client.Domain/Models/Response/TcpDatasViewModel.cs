using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public class TcpDatasViewModel
    {
        public string Oid { get; set; }
        public List<TcpDataPoint> Series { get; set; }
    }
}
