namespace MauiAwaitablePage.Extensions;

using MauiAwaitablePage.Pages;

public static class NavigationExtensions
{
    /// <summary>
    /// This method allows you to push a page onto the navigation stack asynchronously and await its completion before continuing execution. It returns a <see cref="Task{T}"/> object that represents the asynchronous operation and completes when the pushed page is closed.
    /// </summary>
    /// <typeparam name="T">The type of the page result.</typeparam>
    /// <param name="navigation">The INavigation instance on which the page will be pushed.</param>
    /// <param name="page">The AwaitablePage that will be pushed onto the navigation stack.</param>
    /// <param name="isAnimated">Whether or not the transition to the pushed page should be animated.</param>
    /// <returns>A Task{T} object that represents the asynchronous operation and completes when the pushed page is closed.</returns>
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

    public static async Task PushAwaitableAsync(
        this INavigation navigation,
        AwaitablePage page,
        bool isAnimated = true)
    {
        var result = new TaskCompletionSource();
        void PageClosed(object? _, object __)
        {
            page.PageClosed -= PageClosed;
            result?.SetResult();
        }

        page.PageClosed += PageClosed;
        await navigation.PushAsync(page, isAnimated);
        await result.Task;
    }
}