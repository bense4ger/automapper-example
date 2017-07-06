using System;

namespace automapper.example.data.entities
{
    public class Child
    {
        public Guid Id { get; set; }
        public Parent AParent { get; set;}
    }
}