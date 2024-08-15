using Forum.Domain.Entities;
using Forum.Domain.Repositories;

namespace Forum.Domain.UseCases;

public class AnswerQuestion(IAnswerRepository answerRepository)
{
    public async Task<Answer> execute (string instructorId, string questionId, string content)
    {
        var answer = new Answer(content, instructorId, questionId);
        
        await answerRepository.create(answer);

        return answer;
    }
}
