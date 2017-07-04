using System;

namespace automapper.example.domain.models
{
    public class BarModel: Model
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}