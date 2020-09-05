using System.Collections.Generic;
using System.Threading.Tasks;
using CoronaApi.Models;

namespace CoronaApi.Services
{
    public interface CoronaService
    {
        Task<CountryModel> GetByCountryName(string name);
        Task<List<Country>> GetAllCountry();
    }
}