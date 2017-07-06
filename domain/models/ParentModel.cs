using System;

namespace automapper.example.domain.models
{
    public class ParentModel: Model
    {
        public Guid Id { get; set; }
        public ChildModel Child { get; set; }
    }
}