using JokeApp.ViewModels;
using JokeApp.ViewModels;

namespace JokeApp.Views;

public partial class JokeView : ContentPage
{
    public JokeView(JokesViewModel VM)
    {
        InitializeComponent();

        BindingContext = VM;

    }
}