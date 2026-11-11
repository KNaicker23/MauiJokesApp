using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services.Interfaces
{
    public interface IPopUps
    {
        Task ShowPopupAsync(string title, string message, string buttonText);
    }
}
