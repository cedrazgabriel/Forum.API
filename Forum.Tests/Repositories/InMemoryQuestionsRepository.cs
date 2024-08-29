using Forum.Domain.Entities;
using Forum.Domain.Repositories;

namespace Forum.Tests.Repositories
{
    public class InMemoryQuestionsRepository : IQuestionRepository
    {
        public List<Question> items { get; set; } = new List<Question>();

        public async Task create(Question question)
        {
            items.Add(question);
        }

        public async Task<Question?> findBySlug(string slug)
        {
            var question = items.Where(question => question.Slug.Value == slug).FirstOrDefault();

            if (question is null) return null;

            return question;
        }
    }
}
