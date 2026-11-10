using JokeApp.Interfaces;
using JokeApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace JokeApp.Services
{
    public class ChuckNorrisHttpApiService: IChuckNorrisHttpApiService
    {
        private IConfigurationService _configurationService;
        private HttpClient _httpClient;
        public ChuckNorrisHttpApiService(IConfigurationService configurationService)
        {
            _configurationService = configurationService;

            _httpClient = new HttpClient();

        }
        public async Task<string> GetJokeAsync()

        {
            HttpResponseMessage response = await _httpClient.GetAsync(_configurationService.ChuckNorrisApiUrl);
            //return _httpClient.GetStringAsync(_configurationService.ChuckNorrisApiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                ChuckNorrisJoke Joke = JsonConvert.DeserializeObject(jsonContent) as ChuckNorrisJoke;

                if (Joke != null)
                {
                    return Joke.value;
                }
                else
                {
                    return "No joke found.";
                }
            }
            return null;

        }
    }
}
