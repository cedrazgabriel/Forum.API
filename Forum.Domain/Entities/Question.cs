
using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Question(string title, string content, string authorId, Slug slug) : BaseEntity
{
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public UniqueEntiyId AuthorId { get; set; } = new UniqueEntiyId(authorId);
    public UniqueEntiyId? BestAnswerId { get; set; }
    public Slug slug { get; set; } = slug;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}
