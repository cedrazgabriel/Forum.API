using Forum.Domain.Entities;
using Forum.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.UseCases
{
    public class CreateQuestionUseCase(IQuestionRepository questionRepository)
    {
        public async Task<Question> Execute(string authorId, string title, string content)
        {
            var question = Question.Create(title, content, authorId);

            await questionRepository.create(question);

            return question;
        }
    }
}
