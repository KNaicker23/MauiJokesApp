using JokeApp.Models;
using JokeApp.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JokeApp.Services
{
    public class ChuckNorrisApiHttpService : IChuckNorrisApiService
    {
        private HttpClient _httpClient;
        private IConfigurationService _configurationService;
        public ChuckNorrisApiHttpService(IConfigurationService service)
        {
            _configurationService = service;

            _httpClient = new HttpClient();
        }

        public async Task<string> GetJokeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_configurationService.ChuckNorrisApiUrl);

            if (response.IsSuccessStatusCode)//we are interested if it is 200 Ok, and if it is a success
            {
                string jsonContent = await response.Content.ReadAsStringAsync();



                ChuckNorrisJoke joke = JsonSerializer.Deserialize<ChuckNorrisJoke>(jsonContent);

                if (joke != null)
                {
                    return joke.value;
                }
            }

            return null;
        }
    }
}