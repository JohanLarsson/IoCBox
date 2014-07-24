namespace IoCBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Data;

    using Annotations;

    public class Vm : IVm
    {
        public Vm(IModel model, ILogger logger)
        {
            Model = model;
            Log = new CollectionView(logger.Log);
            logger.Logged += (sender, args) => this.Log.Refresh();
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
        public IModel Model { get; private set; }

        public ICollectionView Log { get; private set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
