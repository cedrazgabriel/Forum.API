using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Student : BaseEntity<Student>
{
    public string Name { get; set; }

    private Student(string name, UniqueEntityId? id = null)
         : base(default!, id)
    {
        Name = name;  
    }

    public static Student Create(string name, UniqueEntityId? id = null)
    {
        var student = new Student(name, id);

        return student;
    }
}
