namespace One.Common.Mapping
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfiguration configuration);
    }
}
