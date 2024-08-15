namespace Forum.Domain.Entities;

public class Student(string name, string? id)
{
    public string Id = id ?? Guid.NewGuid().ToString();
    public string Name = name;
}
