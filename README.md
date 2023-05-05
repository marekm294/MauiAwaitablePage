# MauiAwaitablePage

  <h1>About project</h1>
This project adds AwaitablePage to .NET MAUI. <br>
Project was created only to learn how to create NuGet package so I can't ensure improvements and updates.<br><br>

  <b>Initialize:</b><br>
Download nuget from https://www.nuget.org/packages/M.AwaitablePage or find it in NuGet Package Manager as M.AwaitablePage.<br><br>

  <b>Usage:</b><br>
Create Page class which inherits from AwaitablePage<T> where T is your desired return type. Create your ViewModel which implement IViewModel interface. Set your ViewModel as your page's BindingContext. Use PushAwaitableAsync<T> extension method and await.

  <b>Create page C#</b><br>
```C#
namespace Demo.Pages;

using CommunityToolkit.Maui.Markup;
using MauiAwaitablePage.Pages;
using Demo.ViewModels;
using Microsoft.Maui.Controls;

internal sealed class MySuperCoolAwaitablePage : AwaitablePage<string>
{
    public MySuperCoolAwaitablePage()
    {
        BindingContext = new MySuperCoolAwaitableViewModel();
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
                    .Bind(Button.CommandProperty, nameof(MySuperCoolAwaitableViewModel.CloseCommand))
                    .Center(),
            }
        }
        .Fill();
    }
}
```
<br>
  <b>Create page XAML</b><br>  
  
```XAML 
<?xml version="1.0" encoding="utf-8" ?>
<pages:AwaitablePage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="Demo.Pages.MySuperCoolAwaitablePage"
    Title="MySuperCoolAwaitablePageTitle"
    x:TypeArguments="x:String"
    xmlns:pages="clr-namespace:MauiAwaitablePage.Pages;assembly=MauiAwaitablePage"
    xmlns:viewmodels="clr-namespace:Demo.ViewModels"
    x:DataType="viewmodels:MySuperCoolAwaitableViewModel"
    >
    <Grid
        VerticalOptions="Fill"
        HorizontalOptions="Fill"
        >
        <Button 
            WidthRequest="150"
            HeightRequest="150"
            Text="Close page!"
            VerticalOptions="Center"
            HorizontalOptions="Center"
            Command="{Binding CloseCommand}"
            />
    </Grid>
</pages:AwaitablePage>
```
  
```C#
namespace Demo.Pages;

using MauiAwaitablePage.Pages;
using Demo.ViewModels;

public partial class MySuperCoolAwaitablePage : AwaitablePage<string>
{
    public MySuperCoolAwaitablePage()
    {
        BindingContext = new MySuperCoolAwaitableViewModel();
        InitializeComponent();
    }
}
```
<br>

  <b>Create ViewModel</b><br>
```C#
namespace Demo.ViewModels;

using MauiAwaitablePage.ViewModels;
using System.Windows.Input;

internal sealed class MySuperCoolAwaitableViewModel : IAwaitableViewModel<string>
{
    public ICommand CloseCommand { get; private set; }

    public string ReturnValue { get; private set; }

    public MySuperCoolAwaitableViewModel()
    {
        CloseCommand = new Command(async () =>
        {
            var navigation = App.Current.MainPage.Navigation;
            ReturnValue = "Page was closed!";
            await navigation.PopAsync();
        });
    }
}
```
That's all you need.
