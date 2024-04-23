using Gui.dao.DTOs;
using Gui.dao.Persistence.DAO;
using Npgsql;
using Gui.dao.Persistence.Npgsql;

namespace Gui.dao.Persistence.Mapping
{
    public class CountyDAO : ICounty
    {
        private readonly string ConectionString;
        public CountyDAO(string conectionString)
        {
            this.ConectionString = conectionString;
        }

        public void AddCounty(CountyDTO county)
        {
            using (NpgsqlConnection connection = new(this.ConectionString))
            {
                string query = "insert into counties(id, year, county_code, " +
                    "county_name, population, domestic_network, economic_activities, " +
                    "total, domestic_consumption_per_capita) " +
                    "VALUES (@id, @year, @county_code, @county_name, @population, " +
                    "@domestic_network, @economic_activities, @total, " +
                    "@domestic_consumption_per_capita);";
                NpgsqlCommand cmd = new(query, connection);
                cmd.Parameters.AddWithValue("id", county.Id);
                cmd.Parameters.AddWithValue("year", county.Year);
                cmd.Parameters.AddWithValue("county_code", county.CountyCode);
                cmd.Parameters.AddWithValue("county_name", county.CountyName);
                cmd.Parameters.AddWithValue("population", county.Population);
                cmd.Parameters.AddWithValue("domestic_network", county.DomesticNetwork);
                cmd.Parameters.AddWithValue("economic_activities", county.EconomicActivities);
                cmd.Parameters.AddWithValue("total", county.Total);
                cmd.Parameters.AddWithValue("domestic_consumption_per_capita", county.DomesticConsumptionPerCapita);

                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }catch (Exception ex) 
                {
                    MessageBox.Show("dada ja existent");
                }
            }
        }

        public void DeleteCounty(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountyDTO> GetAllCounties()
        {
            throw new NotImplementedException();
        }

        public CountyDTO GetCountyByID(string id)
        {
            CountyDTO county = new CountyDTO();
            using (NpgsqlConnection connection = new(this.ConectionString))
            {
                string query = "select * from counties where id = @id;";
                NpgsqlCommand cmd = new(query,connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    county = NpgsqlUtils.GetCounty(reader);
                }
            }
            return county;
        }

        public void UpdateCounty(CountyDTO county)
        {
            throw new NotImplementedException();

        }
    }
}
