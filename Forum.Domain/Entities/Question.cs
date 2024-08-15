
namespace Forum.Domain.Entities;

public class Question(string title, string content, string authorId, string? id = null)
{
    public string Id { get; set; } = id ?? Guid.NewGuid().ToString();
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public string AuthorId { get; set; } = authorId;
}
