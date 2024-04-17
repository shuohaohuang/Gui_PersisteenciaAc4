using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui.dao.DTOs
{
    public class CountyDTO
    {
        public string ID { get; set; }
        public int Year { get; set; }
        public int CountyCode { get; set; }
        public string CountyName { get; set; }
        public int Population { get; set; }
        public int DomesticNetwork { get; set; }
        public int EconomicActivities { get; set; }
        public int Total { get; set; }
        public float DomesticConsumptionPerCapita { get; set; }
    }
}
