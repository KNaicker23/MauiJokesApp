using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services.Interfaces
{
    public interface IConfigurationService
    {
        string ChuckNorrisApiUrl { get; }
    }
}
