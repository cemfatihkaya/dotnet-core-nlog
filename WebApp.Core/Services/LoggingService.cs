using Microsoft.Extensions.Logging;
using System;
using WebApp.Core.Abstract;

namespace WebApp.Core.Services
{
    public class LoggingService : ILoggingService
    {
        #region ctor

        readonly ILogger<LoggingService> logger;

        public LoggingService(ILogger<LoggingService> logger)
        {
            this.logger = logger;
        }

        #endregion

        #region exception

        public void LogError(string methodName, string message, Exception ex)
        {
            var errorMessage = CreateMessage(methodName, message);

            logger.LogError(ex, errorMessage);
        }

        #endregion

        #region exception with message only

        public void LogError(string methodName, string message)
        {
            var errorMessage = CreateMessage(methodName, message);

            logger.LogError(errorMessage);
        }

        #endregion

        #region warning

        public void LogWarn(string methodName, string message)
        {
            var warnMessage = CreateMessage(methodName, message);
            logger.LogWarning(warnMessage);
        }

        #endregion

        #region info

        public void LogInfo(string methodName, string message)
        {
            var infoMessage = CreateMessage(methodName, message);
            logger.LogInformation(infoMessage);
        }

        #endregion

        #region debug

        public void LogDebug(string methodName, string message)
        {
            var debugMessage = CreateMessage(methodName, message);
            logger.LogDebug(debugMessage);
        }

        #endregion

        #region trace

        public void LogTrace(string methodName, string message)
        {
            var debugMessage = CreateMessage(methodName, message);
            logger.LogTrace(debugMessage);
        }

        #endregion

        #region create message

        static string CreateMessage(string methodName, string message)
        {
            return $"({methodName}) - {message}";
        }

        #endregion
    }
}