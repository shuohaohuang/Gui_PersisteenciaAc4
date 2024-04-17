using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gui.dao.Persistence.DAO;

namespace Gui.dao.Persistence.Mapping
{
    public class CountyDAO : ICounty
    {
        private string id;
        public string Id
        {
            get { return this.id; }
          private set { this.id = value; }
        }
        public int Year { get; set; }
        public int CountyCode { get; set; }
        public string CountyName { get; set; }
        public int Population { get; set; }
        public int DomesticNetwork { get; set; }
        public int EconomicActivities { get; set; }
        public int Total { get; set; }
        public float DomesticConsumptionPerCapita { get; set; }

        public CountyDAO(
            int year,
            int countyCode,
            string countyName,
            int population,
            int domesticNetwork,
            int economicActivities,
            int total,
            float domesticConsumptionPerCapita
        )
        {
            Year = year;
            CountyCode = countyCode;
            CountyName = countyName;
            Population = population;
            DomesticNetwork = domesticNetwork;
            EconomicActivities = economicActivities;
            Total = total;
            DomesticConsumptionPerCapita = domesticConsumptionPerCapita;
            Id = this.Year + this.CountyName;
        }
        void ICounty.AddCounty(County county)
        {
            throw new NotImplementedException();
        }

        void ICounty.DeleteCounty(string id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<County> ICounty.GetAllCounties()
        {
            throw new NotImplementedException();
        }

        County ICounty.GetCountyByID(string id)
        {
            throw new NotImplementedException();
        }

        void ICounty.UpdateCounty(County county)
        {
            throw new NotImplementedException();
        }
    }
}
