using JokeApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace JokeApp.ViewModels
{
    public class JokesViewModel : BaseViewModel
    {
        public ICommand GetJokeCommand { get; set; }

        private string _chuckNorrisJoke;
      
        public string ChuckNorrisJoke
        {
            get { return _chuckNorrisJoke; }
            set
            {
                _chuckNorrisJoke = value;
                OnPropertyChanged();
            }
        }
        private string _dadJoke;

        public string DadJoke
        {
            get { return _dadJoke; }
            set 
            { _dadJoke = value;
                OnPropertyChanged();
            }
        }


        private IChuckNorrisApiService _chuckNorrisApiService;
        private IDadJokeApiService _dadJokeApiService;
        private IPopUps _popupService;

        public JokesViewModel(IChuckNorrisApiService service,IDadJokeApiService dadJokeService, IPopUps popups)
        {
            _chuckNorrisApiService = service;
            _dadJokeApiService = dadJokeService;
            _popupService = popups;

            GetJokeCommand = new Command(FetchJoke);
        }

        private async void FetchJoke(object param)
        {
            try//doing the error handlers differently is a good option--handling each api request separately
            {

                //  throw new HttpRequestException("BOOM");
                ChuckNorrisJoke = await _chuckNorrisApiService.GetJokeAsync();
            }
            catch (Exception ex)
            {
                await _popupService.ShowPopupAsync(" Chuck Norris Joke Error", ex.Message, "OK");
            }

            try
            {
                DadJoke = await _dadJokeApiService.GetJokeAsync();
            }
            catch (Exception ex)
            {
                await _popupService.ShowPopupAsync("Dad Joke Error", ex.Message, "OK");
                
            }
        }
    }
}