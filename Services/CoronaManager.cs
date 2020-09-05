using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoronaApi.Models;
using Newtonsoft.Json;

namespace CoronaApi.Services
{
    public class CoronaManager : CoronaService
    {
        private readonly HttpClient _httpClient;

        public CoronaManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://coronavirus-19-api.herokuapp.com/countries/");
        }

        public async Task<CountryModel> GetByCountryName(string name)
        {
            var responseMessage = await _httpClient.GetAsync($"{name}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CountryModel>(await
                responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<List<Country>> GetAllCountry()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Country>>(await
                responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }

    }
}