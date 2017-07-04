using AutoMapper;

namespace app
{
    public static class MappingConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(new[] { "domain" }));
            Mapper.AssertConfigurationIsValid();
        }

    }
}
