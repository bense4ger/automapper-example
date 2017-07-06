using AutoMapper;
using automapper.example.data.entities;
using automapper.example.domain.models;

namespace automapper.example.domain.mapping
{
    public class EntityProfile: Profile
    {
        public EntityProfile()
        {
            CreateMap<Foo, FooModel>();
            CreateMap<Bar, BarModel>()
                .ForMember(dest => dest.Age, opts => opts.ResolveUsing<AgeResolver>());
            CreateMap<FooBar, FooBarModel>();

            CreateMap<Child, ChildModel>();
            CreateMap<Parent, ParentModel>();
        }
    }
}
