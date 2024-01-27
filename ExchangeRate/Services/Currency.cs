using ExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.Services
{
    public class ValuteService

    {
        ValCurs valCurs = new();
        List<Valute> valList = new();
        HttpClient httpClient;

        public ValuteService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Valute>> GetCurrencies()
        {
            if (valCurs.valutes.Count > 0)
            {
                return valCurs.valutes;
            }

            var response = await httpClient.GetAsync("https://www.cbr-xml-daily.ru/daily_eng.xml");

            if (response.IsSuccessStatusCode)
            {
                valList = await response.Content.ReadFromJsonAsync<List<Valute>>();
            }

            return valList;
        }
    }
}
 