using Microsoft.Build.Framework;

namespace NoOpLogger
{
    public class NoOpNodeLogger : INodeLogger
    {
        public LoggerVerbosity Verbosity { get; set; }
        public string Parameters { get; set; }
        public void Initialize(IEventSource eventSource, int nodeCount) { }
        public void Initialize(IEventSource eventSource) { }
        public void Shutdown() { }
    }
}
