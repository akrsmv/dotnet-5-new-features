using DataAccessDapper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessDapper
{
    public interface ICountriesData
    {
        Task<List<CountryModel>> GetCountries();
        Task InsertCountry(CountryModel country);
    }
}