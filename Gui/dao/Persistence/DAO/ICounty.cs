using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gui.dao.DTOs;
using Gui.dao.DTOs;

namespace Gui.dao.Persistence.DAO
{
    public interface ICounty
    {
        CountyDTO GetCountyByID(string id);
        public IEnumerable<CountyDTO> GetAllCounties();
        void AddCounty(CountyDTO county);
        void UpdateCounty(CountyDTO county);
        void DeleteCounty(string id);
    }
}
