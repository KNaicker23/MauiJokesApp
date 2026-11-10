using JokeApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JokeApp.Services
{
    internal class MauiPopupService : IPopUps
    {
        public async Task ShowingPopUp(string title, string message, string buttonText)
        {
            await Shell.Current.DisplayAlertAsync(title, message, buttonText);

        }
    }
}
