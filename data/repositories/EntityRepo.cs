using System;
using automapper.example.data.entities;

namespace automapper.example.data.repositories
{
    public class EntityRepo
    {
        public Foo GetFooById(Guid id)
        {
            return new Foo
            {
                Id = id,
                Name = "Foo",
                Age = 42  
            };
        }

        public Bar GetBarById(Guid id)
        {
            var dob = DateTime.Now.AddYears(-25);
            return new Bar
            {
                Id = id,
                Name = "Bar",
                DateOfBirth = dob
            };
        }

        public FooBar GetFooBarById(Guid id)
        {
            var foo = GetFooById(Guid.NewGuid());
            var bar = GetBarById(Guid.NewGuid());

            return new FooBar
            {
                Id = id,
                Foo = foo,
                Bar = bar
            };
        }
    }    
}