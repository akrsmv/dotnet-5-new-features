using DataAccessDapper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDapper
{
    public class CountriesData : ICountriesData
    {
        private readonly ISqlDataAccess _db;
        public CountriesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CountryModel>> GetCountries()
        {
            string sql = "select * from dbo.Country";

            return _db.LoadData<CountryModel, dynamic>(sql, new { });
        }

        public Task InsertCountry(CountryModel country)
        {
            var sql = "insert into dbo.Country(Name, Code, Currency)" +
                "values (@Name, @Code, @Currency)";

            return _db.SaveData(sql, country);
        }

    }
}
