namespace MauiDemo1.Pages;

using CommunityToolkit.Maui.Markup;
using MauiAwaitablePage.Pages;
using Microsoft.Maui.Controls;
using System.Windows.Input;

internal sealed class NonGenericAwailablePage : AwaitablePage
{
    private ICommand CloseCommand { get; set; }

    public NonGenericAwailablePage()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            await navigation.PopAsync();
        });
        Content = InitializeContent();
    }

    private View InitializeContent()
    {
        return new Grid()
        {
            Children =
            {
                new Button()
                {
                    Command = CloseCommand,
                }
                .Size(150)
                .Text("Close page!")
                .Center(),
            }
        }
        .Fill();
    }
}
