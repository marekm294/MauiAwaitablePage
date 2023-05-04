namespace MauiAwaitablePage.Extensions;

using MauiAwaitablePage.Pages;

public static class NavigationExtensions
{
    public static async Task<T?> PushAwaitableAsync<T>(
        this INavigation navigation,
        AwaitablePage<T> page,
        bool isAnimated = true)
    {
        var result = new TaskCompletionSource<T?>();

        void PageClosed(object? _, T? args)
        {
            page.PageClosed -= PageClosed;
            result?.SetResult(args);
        }

        page.PageClosed += PageClosed;

        await navigation.PushAsync(page, isAnimated);

        return await result.Task;
    }
}