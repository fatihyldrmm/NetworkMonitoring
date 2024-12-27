using NetworkMonitoring.Api.Persistence.MongoDB.Models;
using NetworkMonitoring.Application.Features.Query.Oid.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Persistence.MongoDB
{
    public class Services
    {
        private SnmpSeriesData ConvertToSnmpSeriesData(SnmpOidChartViewModel viewModel)
        {
            string[] colorCodes = new string[]
            {
                "#1A56DB", "#7E3BF2", "#FF5733", "#DAF7A6", "#FFC300",
                "#581845", "#C70039", "#900C3F", "#FF5733", "#FFC300",
                "#F0F3F4", "#C0392B", "#2980B9", "#8E44AD", "#27AE60",
                "#F39C12", "#D35400", "#1ABC9C", "#2ECC71", "#3498DB"
            };

            var seriesData = new SnmpSeriesData();
            int colorIndex = 0; // Renk seçimi için indeks

            foreach (var item in viewModel.DataPoints)
            {
                var series = new SnmpSeries
                {
                    Name = viewModel.OidType,
                    Color = colorCodes[colorIndex % colorCodes.Length] // Renk dizisinden renk seçimi
                };
                series.Data.Add(new SnmpDataPoint
                {
                    Value = item.OidValue,
                    TimeStamp = item.TimeStamp
                });

                seriesData.Series.Add(series);
                colorIndex++; // Sonraki renge geç
            }
            return seriesData;
        }
    }
}
