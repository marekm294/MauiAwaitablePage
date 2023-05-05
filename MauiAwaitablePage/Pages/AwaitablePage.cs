namespace MauiAwaitablePage.Pages;

public class AwaitablePage : BaseAwaitablePage
{
    internal event EventHandler PageClosed
    {
        add => _pageClosedWeakEventManager.AddEventHandler(value);
        remove => _pageClosedWeakEventManager.RemoveEventHandler(value);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _pageClosedWeakEventManager.HandleEvent(this, null!, nameof(PageClosed));
    }
}