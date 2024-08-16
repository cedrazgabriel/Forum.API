using Forum.Core.Entities;

namespace Forum.Domain.Entities;
public class Answer (string content, string authorId, string questionId) : BaseEntity
{
    public string Content { get; set; } = content;
    public string AuthorId { get; set; } = authorId;
    public string QuestionId { get; set; } = questionId;
}

