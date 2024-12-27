using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public  class TcpDataPoint
    {
        public string Name { get; set; }
        public List<Datas> Data { get; set; }
        public string Color { get; set; }
    }
}
