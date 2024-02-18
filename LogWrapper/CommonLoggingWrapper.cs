using System;
using Common.Logging;
using Microsoft.Extensions.Logging;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace LogWrapper
{
    public class CommonLoggingWrapper: ILog
    {
        private readonly ILogger _logger;

        public CommonLoggingWrapper(ILogger logger)
        {
            _logger = logger;
        }
        public void Trace(object message)
        {
            _logger.LogTrace(message.ToString());
        }

        public void Trace(object message, Exception exception)
        {
            _logger.LogTrace(exception, message.ToString());
        }

        public void TraceFormat(string format, params object[] args)
        {
            _logger.LogTrace(format, args);
        }

        public void TraceFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogTrace(exception, format, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogTrace(format, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogTrace(exception, format, args);
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogTrace(format, args);
                return null;
            });
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogTrace(exception, format, args);
                return null;
            });
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogTrace(format, args);
                return null;
            });
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogTrace(exception, format, args);
                return null;
            });
        }

        public void Debug(object message)
        {
            _logger.LogDebug(message.ToString());
        }

        public void Debug(object message, Exception exception)
        {
            _logger.LogDebug($"{message}: {exception.Message}");
        }

        public void DebugFormat(string format, params object[] args)
        {
            _logger.LogDebug(format, args);
        }

        public void DebugFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogDebug(exception, format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogDebug(format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogDebug(exception, format, args);
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogDebug(format, args);
                return null;
            });
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogDebug(exception, format, args);
                return null;
            });
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogDebug(format, args);
                return null;
            });
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogDebug(exception, format, args);
                return null;
            });
        }

        public void Info(object message)
        {
            _logger.LogInformation(message.ToString());
        }

        public void Info(object message, Exception exception)
        {
            _logger.LogInformation($"{message}: {exception.Message}");
        }

        public void InfoFormat(string format, params object[] args)
        {
            _logger.LogInformation(format, args);
        }

        public void InfoFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogInformation(exception, format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogInformation(format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogInformation(exception, format, args);
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogInformation(format, args);
                return null;
            });
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogInformation(exception, format, args);
                return null;
            });
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogInformation(format, args);
                return null;
            });
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogInformation(exception, format, args);
                return null;
            });
        }

        public void Warn(object message)
        {
            _logger.LogWarning(message.ToString());
        }

        public void Warn(object message, Exception exception)
        {
            _logger.LogWarning($"{message}: {exception.Message}");
        }

        public void WarnFormat(string format, params object[] args)
        {
            _logger.LogWarning(format, args);
        }

        public void WarnFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogWarning(exception, format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogWarning(format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogWarning(exception, format, args);
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogWarning(format, args);
                return null;
            });
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogWarning(exception, format, args);
                return null;
            });
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogWarning(format, args);
                return null;
            });
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogWarning(exception, format, args);
                return null;
            });
        }

        public void Error(object message)
        {
            _logger.LogError(message.ToString());
        }

        public void Error(object message, Exception exception)
        {
            _logger.LogError($"{message}: {exception.Message}");
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _logger.LogError(format, args);
        }

        public void ErrorFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogError(exception, format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogError(format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogError(exception, format, args);
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogError(format, args);
                return null;
            });
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogError(exception, format, args);
                return null;
            });
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogError(format, args);
                return null;
            });
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogError(exception, format, args);
                return null;
            });
        }

        public void Fatal(object message)
        {
            _logger.LogCritical(message.ToString());
        }

        public void Fatal(object message, Exception exception)
        {
            _logger.LogCritical($"{message}: {exception.Message}");
        }

        public void FatalFormat(string format, params object[] args)
        {
            _logger.LogCritical(format, args);
        }

        public void FatalFormat(string format, Exception exception, params object[] args)
        {
            _logger.LogCritical(exception, format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            _logger.LogCritical(format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            _logger.LogCritical(exception, format, args);
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogCritical(format, args);
                return null;
            });
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogCritical(exception, format, args);
                return null;
            });
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogCritical(format, args);
                return null;
            });
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            formatMessageCallback.Invoke((format, args) =>
            {
                _logger.LogCritical(exception, format, args);
                return null;
            });
        }

        public bool IsTraceEnabled => _logger.IsEnabled(LogLevel.Trace);
        public bool IsDebugEnabled => _logger.IsEnabled(LogLevel.Debug);
        public bool IsErrorEnabled => _logger.IsEnabled(LogLevel.Error);
        public bool IsFatalEnabled => _logger.IsEnabled(LogLevel.Critical);
        public bool IsInfoEnabled => _logger.IsEnabled(LogLevel.Information);
        public bool IsWarnEnabled => _logger.IsEnabled(LogLevel.Warning);
        public IVariablesContext GlobalVariablesContext => GlobalVariablesContext;
        public IVariablesContext ThreadVariablesContext => ThreadVariablesContext;
        public INestedVariablesContext NestedThreadVariablesContext => NestedThreadVariablesContext;
    }
}