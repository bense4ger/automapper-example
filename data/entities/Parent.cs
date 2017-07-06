using System;

namespace automapper.example.data.entities
{
    public class Parent
    {
        public Guid Id { get; set; }
        public Child Child { get; set; }
    }
}