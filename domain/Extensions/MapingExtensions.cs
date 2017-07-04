using AutoMapper;

namespace automapper.example.domain.extensions
{
    public static class MapingExtensions
    {
        public static TDest MapTo<TDest>(this object @this) where TDest : class
        {
            return Mapper.Map<TDest>(@this);
        }
    }
}
