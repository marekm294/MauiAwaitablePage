using System.ComponentModel;

namespace MauiDemo1.Helpers;

internal class NotifyPropertyHelper : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}
