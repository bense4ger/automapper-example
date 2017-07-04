using System;

namespace automapper.example.data.entities
{
    public class FooBar
    {
        public Guid Id { get; set; }
        public Foo Foo { get; set; }
        public Bar Bar { get; set; }
    }
}