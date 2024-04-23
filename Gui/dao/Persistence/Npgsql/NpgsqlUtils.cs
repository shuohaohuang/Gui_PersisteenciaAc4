using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gui.dao.DTOs;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Gui.dao.Persistence.Npgsql
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(
                    @"appsettings.json",
                    optional: false,
                    reloadOnChange: true
                )
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static CountyDTO GetCounty(NpgsqlDataReader reader)
        {
            CountyDTO c = new CountyDTO
            {
                Year = reader.GetInt32(1),
                CountyCode = reader.GetInt32(2),
                CountyName = reader.GetString(3),
                Population = reader.GetInt32(4),
                DomesticNetwork = reader.GetInt32(5),
                EconomicActivities = reader.GetInt32(6),
                Total = reader.GetInt32(7),
                DomesticConsumptionPerCapita = reader.GetFloat(8)
            };
            return c;
        }
    }
}
