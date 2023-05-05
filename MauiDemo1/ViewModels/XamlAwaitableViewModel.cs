namespace MauiDemo1.ViewModels;

using MauiAwaitablePage.ViewModels;
using System.Windows.Input;

internal sealed class XamlAwaitableViewModel : IAwaitableViewModel<string>
{
    public ICommand CloseCommand { get; private set; }

    public string ReturnValue { get; private set; }

    public XamlAwaitableViewModel()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            ReturnValue = "Page was closed!";
            await navigation.PopAsync();
        });
    }
}
