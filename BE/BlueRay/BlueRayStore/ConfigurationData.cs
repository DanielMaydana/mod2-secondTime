namespace BlueRayStore
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;

    public class ConfigurationData
    {
        private readonly NameValueCollection appSettings;

        public ConfigurationData()
        {
            this.appSettings = ConfigurationManager.AppSettings;
        }

        public ConfigurationData(NameValueCollection dataValue)
        {
            this.appSettings = dataValue;
        }

        public string GetValueByKey(string key)
        {
            string value = string.Empty;

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("The key is null or empty.");
            }

            value = this.appSettings[key];

            if (value == null)
            {
                throw new ArgumentException("The value doesn't exist in the configurations.");
            }

            return value;
        }
    }
}