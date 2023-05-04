namespace MauiAwaitablePage.Pages;

using MauiAwaitablePage.ViewModels;

public class AwaitablePage<T> : ContentPage
{
    private readonly WeakEventManager _pageClosedWeakEventManager = new();

    internal event EventHandler<T> PageClosed
    {
        add => _pageClosedWeakEventManager.AddEventHandler(value);
        remove => _pageClosedWeakEventManager.RemoveEventHandler(value);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is IAwaitableViewModel<T> awaitableViewModel)
        {
            _pageClosedWeakEventManager.HandleEvent(this, awaitableViewModel.ReturnValue!, nameof(PageClosed));
            return;
        }

        _pageClosedWeakEventManager.HandleEvent(this, null!, nameof(PageClosed));
    }
}