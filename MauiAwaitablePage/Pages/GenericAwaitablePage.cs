namespace MauiAwaitablePage.Pages;

using MauiAwaitablePage.ViewModels;

/// <summary>
/// Represents an awaitable content page with a strongly typed return value.
/// </summary>
/// <typeparam name="T">The type of the return value.</typeparam>
public class AwaitablePage<T> : BaseAwaitablePage
{
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