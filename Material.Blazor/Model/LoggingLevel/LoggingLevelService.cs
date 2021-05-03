using System;

namespace Material.Blazor.Internal
{
    /// <summary>
    /// The internal implementation of <see cref="IMBLoggingLevelService"/>.
    /// </summary>
    internal class LoggingLevelService : IMBLoggingLevelService
    {
        public MBLoggingLevelServiceConfiguration Configuration { get; set; }


        public LoggingLevelService(MBLoggingLevelServiceConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// CurrentLevel returns the logging level
        /// </summary>
        /// <returns></returns>
        public int CurrentLevel()
        {
            return (int)Configuration.LoggingLevel;
        }
    }
}
