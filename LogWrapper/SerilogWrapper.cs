using System;
using Microsoft.Extensions.Logging;
using Serilog.Events;

namespace LogWrapper
{
    public class SerilogWrapper: Serilog.ILogger
    {
        private readonly ILogger _logger;

        public SerilogWrapper(ILogger logger)
        {
            _logger = logger;
        }
        public void Write(LogEvent logEvent)
        {
            var message = logEvent.RenderMessage();
            switch (logEvent.Level)
            {
                case LogEventLevel.Debug:
                    _logger.LogDebug(message);
                    break;
                case LogEventLevel.Error:
                    _logger.LogError(message);
                    break;
                case LogEventLevel.Fatal:
                    _logger.LogCritical(message);
                    break;
                case LogEventLevel.Information:
                    _logger.LogInformation(message);
                    break;
                case LogEventLevel.Verbose:
                    _logger.LogTrace(message);
                    break;
                case LogEventLevel.Warning:
                    _logger.LogWarning(message);
                    break;
            }
        }
    }
}
