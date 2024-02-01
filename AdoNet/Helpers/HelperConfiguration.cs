using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            // Debemos cargar el file config.json
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json", true, true);

            // Recuperamos la clase que proporciona los values del JSON
            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration["SqlHospital"];
            return connectionString;
        }
    }
}