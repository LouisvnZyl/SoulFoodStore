using Microsoft.Extensions.Hosting;

namespace SoulFood.Webhost.Extentions
{
    /// <summary>
    /// Extension methods for Microsoft.Extensions.Hosting.IHostEnvironment.
    /// </summary>
    public static class HostEnvironmentExtensions
    {
        /// <summary>
        /// Checks if the current host environment name is Local.
        /// </summary>
        /// <param name="hostEnvironment">
        /// An instance of <see cref="IHostEnvironment"/>.
        /// </param>
        /// <returns>
        /// True if the environment name is Local, otherwise false.
        /// </returns>
        public static bool IsLocal(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.IsEnvironment("local");
        }

        /// <summary>
        /// Checks if the current host environment name is AzureDevelopment.
        /// </summary>
        /// <param name="hostEnvironment">
        /// An instance of <see cref="IHostEnvironment"/>.
        /// </param>
        /// <returns>
        /// True if the environment name is AzureDevelopment, otherwise false.
        /// </returns>
        public static bool IsAzureDevelopment(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.IsEnvironment("AZUREDEVELOPMENT");
        }
    }
}
