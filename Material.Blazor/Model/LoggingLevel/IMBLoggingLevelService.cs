using System;

namespace Material.Blazor
{
    /// <summary>
    /// Interface for the Material.Blazor logging level service
    /// 
    public interface IMBLoggingLevelService
    {
        /// <summary>
        /// Logging service configuration
        /// </summary>
        MBLoggingLevelServiceConfiguration Configuration { get; set; }

        public int CurrentLevel();
    }
}
