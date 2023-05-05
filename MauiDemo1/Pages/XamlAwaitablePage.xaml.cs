namespace MauiDemo1.Pages;

using MauiAwaitablePage.Pages;
using MauiDemo1.ViewModels;

public partial class XamlAwaitablePage : AwaitablePage<string>
{
    public XamlAwaitablePage()
    {
        BindingContext = new XamlAwaitableViewModel();
        InitializeComponent();
    }
}