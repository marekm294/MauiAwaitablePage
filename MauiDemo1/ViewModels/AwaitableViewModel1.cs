namespace MauiDemo1.ViewModels;

using MauiAwaitablePage.ViewModels;
using System.Windows.Input;

internal sealed class AwaitableViewModel1 : IAwaitableViewModel<int>
{
    public ICommand CloseCommand { get; private set; }

    public int ReturnValue { get; private set; }

    public AwaitableViewModel1()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            ReturnValue = 19;
            await navigation.PopAsync();
        });
    }
}
