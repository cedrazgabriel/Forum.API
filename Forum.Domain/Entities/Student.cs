using Forum.Core.Entities;

namespace Forum.Domain.Entities;

public class Student(string name) : BaseEntity
{
    public string Name = name;
}
