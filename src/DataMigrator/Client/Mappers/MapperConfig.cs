using System.Reflection;
using AutoMapper;

namespace Client.Mappers
{
    public class MapperConfig
    {
        public static MapperConfiguration GetMapper()
        {
            var configurationProvider = new MapperConfiguration(MapperProfiler.Configure);

            return configurationProvider;
        }


        public static MapperConfiguration GetAssemblyMapper()
        {
            var standaloneDatabaseAssembly = Assembly.Load($"{nameof(StandaloneDatabase)}");
            var saaSDatabaseAssembly = Assembly.Load($"{nameof(SaaSDatabase)}");

            var config = new MapperConfiguration(cfg => {
                cfg.AddMaps(standaloneDatabaseAssembly, saaSDatabaseAssembly);
            });

            return config;
        }


    }
}