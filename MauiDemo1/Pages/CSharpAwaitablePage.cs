namespace MauiDemo1.Pages;

using CommunityToolkit.Maui.Markup;
using MauiAwaitablePage.Pages;
using MauiDemo1.ViewModels;
using Microsoft.Maui.Controls;

internal sealed class CSharpAwaitablePage : AwaitablePage<int>
{
    public CSharpAwaitablePage()
    {
        BindingContext = new CSharpAwaitableViewModel();
        Content = InitializeContent();
    }

    private View InitializeContent()
    {
        return new Grid()
        {
            Children =
            {
                new Button()
                    .Size(150)
                    .Text("Close page!")
                    .Bind(Button.CommandProperty, nameof(CSharpAwaitableViewModel.CloseCommand))
                    .Center(),
            }
        }
        .Fill();
    }
}