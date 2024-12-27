using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NetworkMonitoring.Api.Application.OidLists;
using NetworkMonitoring.Api.Persistence.Context;
using NetworkMonitoring.Api.Persistence.Fetcher;
using NetworkMonitoring.Api.Persistence.MongoDB.Models;
using NetworkMonitoring.Application.Features.Query.Oid.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitoring.Api.Persistence.BackgroundServices
{
    public class SnmpDataCollectorService : BackgroundService
    {
        private readonly ILogger<SnmpDataCollectorService> _logger;
        private readonly MongoDBContext _dbContext;

        public SnmpDataCollectorService(ILogger<SnmpDataCollectorService> logger, MongoDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Fetching SNMP data at: {time}", DateTimeOffset.Now);
                //try
                //{
                //    FetchAndStoreData();
                //}
                //catch (Exception ex)
                //{
                //    _logger.LogError(ex, "Error fetching SNMP data.");
                //}
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }

        private void FetchAndStoreData()
        {
            var viewModel = SnmpDataFetcher.FetchSnmpData("TCP", OidRepository.GetTcpOids(), OidRepository.GetTcpOidNames(), "192.168.1.1");
            var data = ConvertToSnmpSeriesData(viewModel);
            _dbContext.SnmpData.InsertOne(data);
        }

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
