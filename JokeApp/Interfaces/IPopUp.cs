using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Interfaces
{
    internal interface IPopUp
    {
        Task ShowingPopUp(string title, string message, string buttonText);
    }
}
