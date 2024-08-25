
using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Question : BaseEntity<Question>
{
    public string Title { get; set; }
    public string Content { get; set; } 
    public UniqueEntityId AuthorId { get; set; } 
    public Slug Slug { get; set; } 
    public UniqueEntityId? BestAnswerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    private Question(string title, string content, UniqueEntityId authorId, Slug slug, UniqueEntityId? id = null, UniqueEntityId? bestAnswerId = null)
        : base(default!, id)
    {
        Title = title;
        Content = content;
        AuthorId = authorId;
        Slug = slug;
        CreatedAt = DateTime.UtcNow;
        BestAnswerId = bestAnswerId;
    }
    public static Question Create(string title, string content, string authorId, UniqueEntityId? id = null, string? slug = null, string? bestAnswerId = null)
    {
        var question = new Question(title,content, new UniqueEntityId(authorId), Slug.createFromText(slug ?? title), id, new UniqueEntityId(bestAnswerId));

        return question;
    }
    private void Touch()
    {
        this.UpdatedAt = DateTime.UtcNow;
    }
}
