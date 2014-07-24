namespace IoCBox
{
    using System.ComponentModel;

    public interface IModel : INotifyPropertyChanged
    {
        event PropertyChangedEventHandler PropertyChanged;
        string Name { get; set; }
    }
}