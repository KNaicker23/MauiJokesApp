using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Interfaces
{
    public interface IConfigurationService
    {
        string ChuckNorrisApiUrl { get; }
    }
}
