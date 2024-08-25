using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Student : BaseEntity<Student>
{
    public string Name { get; set; }

    public Student(string name, UniqueEntityId? id = null)
         : base(default!, id)
    {
        Name = name;  
    }
}
