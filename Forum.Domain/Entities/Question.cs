
using Forum.Core.Entities;
using Forum.Domain.Entities.ValueObjects;

namespace Forum.Domain.Entities;

public class Question : BaseEntity<Question>
{
    public string Title { get; set; }
    public string Content { get; set; } 
    public UniqueEntityId AuthorId { get; set; } 
    public Slug Slug { get; set; } 


    public Question(string title, string content, UniqueEntityId authorId, Slug slug, UniqueEntityId? id = null)
        : base(default!, id)
    {
        Title = title;
        Content = content;
        AuthorId = authorId;
        Slug = slug;
    }
}
