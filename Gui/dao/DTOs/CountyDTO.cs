using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui.dao.DTOs
{
    public class CountyDTO
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

        public CountyDTO() { }

        public CountyDTO(
            County county
        )
        {
            Year =county.Year;
            CountyCode = county.CountyCode;
            CountyName = county.CountyName;
            Population = county.Population;
            DomesticNetwork = county.DomesticNetwork;
            EconomicActivities = county.EconomicActivities;
            Total = county.Total;
            DomesticConsumptionPerCapita = county.DomesticConsumptionPerCapita;
            Id = this.Year + this.CountyName;
        }
    }
}
