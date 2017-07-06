using System;
using AutoMapper;
using automapper.example.domain.models;
using automapper.example.data.repositories;
using automapper.example.domain.extensions;

namespace automapper.example.domain.services
{
    public class ApplicationService
    {
        public ApplicationService()
        {
            Repo = new EntityRepo();
        }

        private EntityRepo Repo { get; }

        public FooModel GetFooById(Guid id)
        {
            var foo = Repo.GetFooById(id);
            var model = Mapper.Map<FooModel>(foo);

            return model;
        }

        public BarModel GetBarById(Guid id)
        {
            var bar = Repo.GetBarById(id);
            return bar.MapTo<BarModel>();
        }

        public FooBarModel GetFooBarById(Guid id)
        {
            var fooBar = Repo.GetFooBarById(id);
            return fooBar.MapTo<FooBarModel>();
        }

        public ParentModel GetParentById(Guid id)
        {
            var parent = Repo.GetComplexNested(id);
            return parent.MapTo<ParentModel>();
        }
    }
}