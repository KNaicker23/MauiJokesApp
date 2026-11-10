using System;
using System.Collections.Generic;
using System.Text;
using JokeApp.Interfaces;

namespace JokeApp.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string ChuckNorrisApiUrl { get; }

        public ConfigurationService()
        {
            ChuckNorrisApiUrl = "https://api.chucknorris.io/jokes/random";
        }
    }
}
