using Microsoft.Build.Framework;

namespace NoOpLogger
{
    public class NoOpLogger : ILogger
    {
        public LoggerVerbosity Verbosity { get; set; }
        public string Parameters { get; set; }
        public void Initialize(IEventSource eventSource) { }
        public void Shutdown() { }
    }
}
