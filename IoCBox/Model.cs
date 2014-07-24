namespace IoCBox
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class Model : IModel
    {
        private string _name;

        public Model(ILogger logger)
        {
            Logger = logger;
            Name = "test name";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ILogger Logger { get; private set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                Logger.LogEvent(new LogEntry(string.Format("Name changed to: " + _name)));
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
