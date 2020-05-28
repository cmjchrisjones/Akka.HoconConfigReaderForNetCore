using Akka.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CJTech.Akka.Helpers.HoconConfigReader
{
    public class AkkaHoconConfigurationHelper
    {
        public Config ReadHoconConfigFile(string filePath)
        {
            var hoconFile = XElement.Parse(File.ReadAllText($"{filePath}"));
            var config = ConfigurationFactory.ParseString(hoconFile.Descendants("hocon").Single().Value);
            return config;
        }
    }
}