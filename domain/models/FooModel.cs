using System;

namespace automapper.example.domain.models
{
    public class FooModel: Model
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
    }    
}