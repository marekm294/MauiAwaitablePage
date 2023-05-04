namespace MauiDemo1.ViewModels;

using MauiAwaitablePage.ViewModels;
using System.Windows.Input;

internal sealed class AwaitableViewModel2 : IAwaitableViewModel<string>
{
    public ICommand CloseCommand { get; private set; }

    public string ReturnValue { get; private set; }

    public AwaitableViewModel2()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            ReturnValue = "ZAVRENOOOOOOO!";
            await navigation.PopAsync();
        });
    }
}
