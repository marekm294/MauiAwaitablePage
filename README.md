# MauiAwaitablePage

<h1>About project</h1>
This project adds AwaitablePage to .NET MAUI. <br>
Project was created only to learn how to create NuGet package so I can't ensure improvements and updates.<br><br>

<b>Initialize:</b><br>
Download nuget from https://www.nuget.org/packages/M.AwaitablePage or find it in NuGet Package Manager as M.AwaitablePage.<br><br>

<b>Usage:</b><br>
Create Page class which inherits from AwaitablePage<T> where T is your desired return type. Create your ViewModel which implement IViewModel interface. Set your ViewModel as your page's BindingContext. Use PushAwaitableAsync<T> extension method and await.




