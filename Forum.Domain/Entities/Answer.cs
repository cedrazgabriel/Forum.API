using Forum.Core.Entities;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace Forum.Domain.Entities;
public class Answer : BaseEntity<Answer>
{
    public string Content { get; private set; }
    public UniqueEntityId AuthorId { get; private set; }
    public UniqueEntityId QuestionId { get; private set; }

    private Answer(string content, UniqueEntityId authorId, UniqueEntityId questionId, UniqueEntityId? id = null)
        : base(default!, id)
    {
        Content = content;
        AuthorId = authorId;
        QuestionId = questionId;
    }

    public static Answer Create(string content, string authorId, string questionId, UniqueEntityId? id = null)
    {
        var answer = new Answer(content, new UniqueEntityId(authorId), new UniqueEntityId(questionId), id);

        return answer;
    }

}

