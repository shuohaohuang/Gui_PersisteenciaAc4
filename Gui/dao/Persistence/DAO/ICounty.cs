using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gui.dao.DTOs;

namespace Gui.dao.Persistence.DAO
{
    public interface ICounty
    {
        County GetCountyByID(string id);
        public IEnumerable<County> GetAllCounties();
        void AddCounty(County county);
        void UpdateCounty(County county);
        void DeleteCounty(string id);
    }
}
