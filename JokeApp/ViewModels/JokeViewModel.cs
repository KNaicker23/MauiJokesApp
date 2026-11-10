//using Android.App;
using JokeApp.Interfaces;
using JokeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace JokeApp.ViewModels
{
    public class JokesViewModel : BaseViewModel
    {


        public ICommand GetJokeCommand { get; }
        public int ChuckNorrisJoke
        {
            get { return ChuckNorrisJoke; }
            set
            {
                ChuckNorrisJoke = value;
                OnPropertyChanged();
            }
        }

        private IChuckNorrisHttpApiService _chuckNorriesApiService;
        public JokesViewModel(IChuckNorrisHttpApiService service)

        {
            _chuckNorriesApiService = service;
            GetJokeCommand = new Command(FetchJoke);
        }
        private async void FetchJoke(object param)
        {
            await _chuckNorriesApiService.GetJokeAsync();
        }
    }
}
