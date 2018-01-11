using Microsoft.Build.Framework;

namespace NoOpLogger
{
    public class NoOpForwardingLogger : IForwardingLogger
    {
        public IEventRedirector BuildEventRedirector { get; set; }
        public int NodeId { get; set; }
        public LoggerVerbosity Verbosity { get; set; }
        public string Parameters { get; set; }
        public void Initialize(IEventSource eventSource, int nodeCount) { }
        public void Initialize(IEventSource eventSource) { }
        public void Shutdown() { }
    }
}
