namespace MauiDemo1.ViewModels;

using CommunityToolkit.Maui.Alerts;
using MauiAwaitablePage.Extensions;
using MauiDemo1.Helpers;
using MauiDemo1.Pages;
using System.Windows.Input;

internal sealed class MainViewModel : NotifyPropertyHelper
{
    public ICommand NavigateToCSharpPageCommand { get; private set; }

    public ICommand NavigateToXamlPageCommand { get; private set; }

    public ICommand NavigateToNonGenericPageCommand { get; private set; }

    public ICommand NavigateToNonGenericModalPageCommand { get; private set; }

    public MainViewModel()
    {
        NavigateToCSharpPageCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            var result = await navigation.PushAwaitableAsync(new CSharpAwaitablePage());
            await Toast.Make($"Result from C# page = {result}").Show();
        });

        NavigateToXamlPageCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            var result = await navigation.PushAwaitableAsync(new XamlAwaitablePage());
            await Toast.Make($"Result from Xaml page = {result}").Show();
        });

        NavigateToNonGenericPageCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            await navigation.PushAwaitableAsync(new NonGenericAwailablePage());
            await Toast.Make($"No result from page").Show();
        });

        NavigateToNonGenericModalPageCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            await navigation.PushAwaitableModalAsync(new NonGenericAwailableModalPage());
            await Toast.Make($"No result from modal page").Show();
        });
    }
}