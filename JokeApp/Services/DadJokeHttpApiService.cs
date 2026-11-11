using JokeApp.Models;
using JokeApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JokeApp.Services
{
    public class DadJokeHttpApiService : IDadJokeApiService
    {
        private HttpClient _httpClient;
        private IConfigurationService _configurationService;
        public DadJokeHttpApiService(IConfigurationService service)
        {
            _configurationService = service;

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<string> GetJokeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_configurationService.DadJokeApiUrl);

            if (response.IsSuccessStatusCode)//we are interested if it is 200 Ok, and if it is a success
            {
                string jsonContent = await response.Content.ReadAsStringAsync();



                DadJoke joke = JsonSerializer.Deserialize<DadJoke>(jsonContent);

                if (joke != null)
                {
                    return joke.joke;
                }
            }
            return null;
        }

    }
}
