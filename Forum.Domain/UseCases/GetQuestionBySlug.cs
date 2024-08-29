using Forum.Domain.Entities;
using Forum.Domain.Repositories;

namespace Forum.Domain.UseCases
{
    public class GetQuestionBySlugUseCase(IQuestionRepository questionRepository)
    {
        public async Task<Question> Execute(string slug)
        {
            var question = await questionRepository.findBySlug(slug);

            if(question is null)
            {
                throw new Exception("Question not found");
            }

            return question;
        }
    }
}
