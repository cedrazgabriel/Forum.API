using Forum.Core.Entities;
namespace Forum.Domain.Entities;

public class Instructor : BaseEntity<Instructor>
{
    public string Name { get; set; }
    private Instructor(string name, UniqueEntityId? id = null)
    : base(default!, id)
    {
        Name = name;
    }

    public static Instructor Create(string name, UniqueEntityId? id = null)
    {
        var instructor = new Instructor(name, id);

        return instructor;
    }
}


