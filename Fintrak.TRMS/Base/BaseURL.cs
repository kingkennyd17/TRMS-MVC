using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace Fintrak.TRMS.Base
{
    public class BaseURL
    {
        static IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        public string Url = configuration.GetSection("BaseURL:Url").Value;

        public string Username = configuration.GetSection("Auth:Name").Value;

        public string Password = configuration.GetSection("Auth:Code").Value;

    }


}
