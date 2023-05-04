namespace MauiDemo1.Pages;

using MauiAwaitablePage.Pages;
using MauiDemo1.ViewModels;

public partial class AwaitablePage2 : AwaitablePage<string>
{
    public AwaitablePage2()
    {
        BindingContext = new AwaitableViewModel1();
        InitializeComponent();
    }
}