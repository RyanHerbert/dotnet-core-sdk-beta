namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;


    public static class LogFactory
    {
        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.Create(builder =>
            {
                builder.AddDebug();
            }).CreateLogger(classType.FullName);
        }
    }
}