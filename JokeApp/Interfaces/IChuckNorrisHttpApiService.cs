using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Interfaces
{
    public interface IChuckNorrisHttpApiService
    {
        Task<string> GetJokeAsync();
    }
}
