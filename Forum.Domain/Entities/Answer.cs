using Forum.Core.Entities;

namespace Forum.Domain.Entities;
public class Answer (string content, string authorId, string questionId) : BaseEntity
{
    public string Content { get; set; } = content;
    public UniqueEntiyId AuthorId { get; set; } = new UniqueEntiyId( authorId);
    public UniqueEntiyId QuestionId { get; set; } = new UniqueEntiyId(questionId);
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}

