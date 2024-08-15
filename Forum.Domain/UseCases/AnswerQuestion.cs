using Forum.Domain.Entities;

namespace Forum.Domain.UseCases;

public class AnswerQuestion
{
    public Answer execute (string instructorId, string questionId, string content)
    {
        var answer = new Answer(content, instructorId, questionId);

        return answer;
    }
}
