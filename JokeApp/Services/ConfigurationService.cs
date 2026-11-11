using System;
using System.Collections.Generic;
using System.Text;
using JokeApp.Services.Interfaces;

namespace JokeApp.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string ChuckNorrisApiUrl { get; }
        public string DadJokeApiUrl { get; }

        public ConfigurationService()
        {
            ChuckNorrisApiUrl = "https://api.chucknorris.io/jokes/random";
            DadJokeApiUrl = "https://icanhazdadjoke.com/";
        }
    }
}
