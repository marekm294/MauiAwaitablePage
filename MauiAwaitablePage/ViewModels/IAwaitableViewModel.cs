namespace MauiAwaitablePage.ViewModels;

public interface IAwaitableViewModel<T>
{
    T ReturnValue { get; }
}