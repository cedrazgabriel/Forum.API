using Forum.Core.Entities;
namespace Forum.Domain.Entities;

public class Instructor : BaseEntity<Instructor>
{
    public string Name { get; set; }
    public Instructor(string name, UniqueEntityId? id = null)
    : base(default!, id)
    {
        Name = name;
    }
}


