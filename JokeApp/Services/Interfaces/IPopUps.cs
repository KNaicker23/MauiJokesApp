using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services.Interfaces
{
    internal interface IPopUps
    {
        Task ShowingPopUp(string title, string message, string buttonText);
    }
}
