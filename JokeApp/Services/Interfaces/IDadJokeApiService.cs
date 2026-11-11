using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services.Interfaces
{
    public interface IDadJokeApiService
    {
        Task<string> GetJokeAsync();//TODO: Implement the method to fetch a dad joke from the API
    }
}
