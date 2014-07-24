namespace IoCBox
{
    using System;
    using System.Collections.Generic;

    public interface ILogger
    {
        void LogEvent(LogEntry @event);
        IEnumerable<LogEntry> Log { get; }
        event EventHandler Logged;
    }
}