using System;

namespace automapper.example.domain.models
{
    public class ChildModel: Model
    {
        public Guid Id { get; set; }
        public ParentModel AParent { get; set; }
    }
}