using Microsoft.Extensions.Logging;

using System;

namespace Laerdal.Dfu.Enums
{
    public enum DfuLogLevel : long
    {
        Debug = 0,

        Verbose = 1,

        Info = 5,

        Application = 10, // 0x000000000000000A

        Warning = 15, // 0x000000000000000F

        Error = 20 // 0x0000000000000014
    }
    
    public static class DfuLogLevelExtensions 
    {
        public static LogLevel ToLogLevel(this DfuLogLevel logLevel)
        {
            switch (logLevel)
            {
                case DfuLogLevel.Debug:
                    return LogLevel.Debug;
                case DfuLogLevel.Verbose:
                    return LogLevel.Trace;
                case DfuLogLevel.Info:
                case DfuLogLevel.Application:
                    return LogLevel.Information;
                case DfuLogLevel.Warning:
                    return LogLevel.Warning;
                case DfuLogLevel.Error:
                    return LogLevel.Error;
                default:
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null);
            }
        }
    }
}