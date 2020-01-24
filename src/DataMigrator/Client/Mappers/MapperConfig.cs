using AutoMapper;

namespace Client.Mappers
{
    public class MapperConfig
    {
        public static MapperConfiguration GetProvider()
        {
            var configurationProvider = new MapperConfiguration(MapperProfile.Configure);

            return configurationProvider;
        }
    }
}