using Microsoft.Extensions.Configuration;

namespace MyFin.Infrastructure.Data
{
    public static class MyFinConnection
    {
        public static string GetConnectionString() 
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var nameDirectory = Path.GetDirectoryName(currentDirectory);

            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine($"{nameDirectory}\\MyFin.Api", "appsettings.json"));

            var root = builder.Build();
            return root.GetConnectionString("MyFin") ?? throw new ArgumentException("ConnectionString.Failed");
    
        }
    }
}
