using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PostgreSQLTest.Framework
{
    public class Properties : IProperties
    {
        public string cnnString { get; set; }
        private ConfigurationRoot _configuration;

        /// <summary>
        /// Set the connection string for database services
        /// </summary>
        public Properties ()
        {           

            var path = Directory.GetCurrentDirectory() + "\\" + "Framework";
            var builder = new ConfigurationBuilder()
            .SetBasePath(path)
            .AddJsonFile("settings.json").Build();

            _configuration = (ConfigurationRoot)builder;

            cnnString = GetAppSettingsValue("ConnectionStrings", "CnnString");
        }

        private string GetAppSettingsValue(string sectionName, string key)
        {            
            var section = (sectionName + ":" + key).ToLower();
            var keyValue = _configuration[section];
            return keyValue;
        }
    }
}
