namespace IoCBox
{
    using System.ComponentModel;

    public interface IVm : INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
        IModel Model { get;  }
    }
}