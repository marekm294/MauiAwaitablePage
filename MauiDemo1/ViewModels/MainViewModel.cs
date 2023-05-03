namespace MauiDemo1.ViewModels;

using CommunityToolkit.Maui.Alerts;
using MauiDemo1.Helpers;
using System.Windows.Input;

internal sealed class MainViewModel : NotifyPropertyHelper
{
    public ICommand NavigateToPage1Command { get; private set; }

    public ICommand NavigateToPage2Command { get; private set; }

    public int Counter1 { get; set; }

    public int Counter2 { get; set; }

    public MainViewModel()
    {
        NavigateToPage1Command = new Command(() =>
        {
            Counter1++;
            Toast.Make("Page1").Show();
        });

        NavigateToPage2Command = new Command(() =>
        {
            Counter2++;
            Toast.Make("Page2").Show();
        });
    }
}