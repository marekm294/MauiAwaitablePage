namespace MauiDemo1.ViewModels;

using CommunityToolkit.Maui.Alerts;
using MauiAwaitablePage.Extensions;
using MauiDemo1.Helpers;
using MauiDemo1.Pages;
using System.Windows.Input;

internal sealed class MainViewModel : NotifyPropertyHelper
{
    public ICommand NavigateToPage1Command { get; private set; }

    public ICommand NavigateToPage2Command { get; private set; }

    public int Counter1 { get; set; }

    public int Counter2 { get; set; }

    public MainViewModel()
    {
        NavigateToPage1Command = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            var result = await navigation.PushAwaitableAsync(new AwaitablePage1());
            Counter1++;
            await Toast.Make($"Result from page 1 = {result}").Show();
        });

        NavigateToPage2Command = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            var result = await navigation.PushAwaitableAsync(new AwaitablePage2());
            Counter2++;
            await Toast.Make($"Result from page 2 = {result}").Show();
        });
    }
}