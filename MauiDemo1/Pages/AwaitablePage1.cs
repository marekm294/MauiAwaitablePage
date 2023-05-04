namespace MauiDemo1.Pages;

using CommunityToolkit.Maui.Markup;
using MauiAwaitablePage.Pages;
using MauiDemo1.ViewModels;
using Microsoft.Maui.Controls;

internal sealed class AwaitablePage1 : AwaitablePage<int>
{
    public AwaitablePage1()
    {
        BindingContext = new AwaitableViewModel1();
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
                    .Bind(Button.CommandProperty, nameof(AwaitableViewModel1.CloseCommand))
                    .Center(),
            }
        }
        .Fill();
    }
}