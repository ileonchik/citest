using Microsoft.Extensions.Configuration;

namespace CiTest.Services
{
    public class ConfigurationService
    {
        public static IConfigurationBuilder GetBuilder()
        {
            return new ConfigurationBuilder()

                .AddJsonFile(@"config\ConnectionStrings.json");
        }
    }
}
