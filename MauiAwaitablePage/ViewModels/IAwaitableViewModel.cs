namespace MauiAwaitablePage.ViewModels;

/// <summary>
/// Defines an interface that must be implemented by AwaitablePage's BindingContext.
/// </summary>
/// <typeparam name="T">The type of the value returned by the AwaitablePage.</typeparam>
public interface IAwaitableViewModel<T>
{
    /// <summary>
    /// Value returned by the AwaitablePage after it has been awaited.
    /// </summary>
    T ReturnValue { get; }
}