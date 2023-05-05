namespace MauiAwaitablePage.Pages;

public abstract class BaseAwaitablePage : ContentPage
{
    internal readonly WeakEventManager _pageClosedWeakEventManager = new();
}