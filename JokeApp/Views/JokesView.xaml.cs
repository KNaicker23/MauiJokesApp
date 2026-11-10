using JokeApp.ViewModels;
using JokeApp.Services;

namespace JokeApp.Views;

public partial class JokesView : ContentPage
{
    public JokesView(JokesViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;

    }
}