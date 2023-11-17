using System;
using Newtonsoft.Json;

namespace TimTour_Backend.Business.Configuration
{
    public class ConfigurationManager
    {
        private const string ConfigFileName = "config.json";

        public Config GetConfiguration()
        {
            if (!File.Exists(ConfigFileName))
            {
                Console.WriteLine("Config file not found. Creating a default config.json.");
                CreateDefaultConfigFile();
            }

            string configJson = File.ReadAllText(ConfigFileName);
            var existingConfig = JsonConvert.DeserializeObject<Config>(configJson);
            var defaultConfig = new Config();

            var ConfigProperties = typeof(Config).GetProperties();
            foreach (var property in ConfigProperties)
            {
                var existingValue = property.GetValue(existingConfig);
                if (existingValue == null)
                {
                    var defaultValue = property.GetValue(defaultConfig);
                    property.SetValue(existingConfig, defaultValue);
                }
            }

            var existingConfigProperties = typeof(Config).GetProperties();
            foreach (var property in existingConfigProperties)
            {
                var ConfigProperty = ConfigProperties.FirstOrDefault(p => p.Name == property.Name);
                if (ConfigProperty == null)
                {
                    property.SetValue(existingConfig, null);
                }
            }

            string updatedConfigJson = JsonConvert.SerializeObject(existingConfig, Formatting.Indented);
            File.WriteAllText(ConfigFileName, updatedConfigJson);

            return existingConfig;
        }



        private void CreateDefaultConfigFile()
        {
            var defaultConfig = new Config();
            string json = JsonConvert.SerializeObject(defaultConfig, Formatting.Indented);
            File.WriteAllText(ConfigFileName, json);
        }
    }
}

