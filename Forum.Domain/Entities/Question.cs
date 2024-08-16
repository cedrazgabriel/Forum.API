
using Forum.Core.Entities;

namespace Forum.Domain.Entities;

public class Question(string title, string content, string authorId) : BaseEntity
{
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public string AuthorId { get; set; } = authorId;
}
