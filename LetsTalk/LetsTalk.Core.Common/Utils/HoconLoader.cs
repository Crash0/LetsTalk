using System.IO;
using Akka.Configuration;

namespace LetsTalk.Core.Common.Utils
{
    /// <summary>
    ///     Used to load <see cref="Config" /> objects from stand-alone HOCON files.
    /// </summary>
    public static class HoconLoader
    {
        public static Config ParseConfig(string hoconPath)
        {
            return ConfigurationFactory.ParseString(File.ReadAllText(hoconPath));
        }
    }
}