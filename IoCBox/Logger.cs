using System.Collections.Generic;

namespace IoCBox
{
    using System;

    public class Logger : ILogger
    {
        private readonly List<LogEntry> log = new List<LogEntry>();

        public event EventHandler Logged;

        public void LogEvent(LogEntry @event)
        {
            log.Add(@event);
            var handler = this.Logged;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        public IEnumerable<LogEntry> Log
        {
            get
            {
                return this.log;
            }
        }
    }
}
