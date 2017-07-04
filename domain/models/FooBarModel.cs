using System;

namespace automapper.example.domain.models
{
    public class FooBarModel: Model
    {
        public Guid Id { get; set; }
        public FooModel Foo { get; set; }
        public BarModel Bar { get; set; }
    }
}