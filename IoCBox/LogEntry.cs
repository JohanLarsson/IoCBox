namespace IoCBox
{
    using System;

    public class LogEntry
    {
        public LogEntry(string message)
        {
            this.Time = DateTime.Now;
            this.Message = message;
        }
        public DateTime Time { get; private set; }
        public string Message { get; private set; }
    }
}