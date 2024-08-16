
using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Question(string title, string content, string authorId, Slug slug) : BaseEntity
{
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public string AuthorId { get; set; } = authorId;
    public Slug slug { get; set; } = slug;
}
