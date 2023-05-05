namespace MauiDemo1.ViewModels;

using MauiAwaitablePage.ViewModels;
using System.Windows.Input;

internal sealed class CSharpAwaitableViewModel : IAwaitableViewModel<int>
{
    public ICommand CloseCommand { get; private set; }

    public int ReturnValue { get; private set; }

    public CSharpAwaitableViewModel()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            ReturnValue = 23;
            await navigation.PopAsync();
        });
    }
}
