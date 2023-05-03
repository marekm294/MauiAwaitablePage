using MauiDemo1.ViewModels;

namespace MauiDemo1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}