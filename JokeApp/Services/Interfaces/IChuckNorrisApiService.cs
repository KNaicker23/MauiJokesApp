using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services.Interfaces
{
    public interface IChuckNorrisApiService
    {
        Task<string> GetJokeAsync();
    }
}
