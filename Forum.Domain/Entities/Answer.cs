namespace Forum.Domain.Entities;
public class Answer (string content, string authorId, string questionId, string? id = null)
{
    public string Id { get; set; } = id ?? Guid.NewGuid().ToString();
    public string Content { get; set; } = content;
    public string AuthorId { get; set; } = authorId;
    public string QuestionId { get; set; } = questionId;
}

