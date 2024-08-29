using Forum.Domain.Entities;
using Forum.Domain.UseCases;
using Forum.Tests.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Forum.Tests.UseCases
{
    public class GetQuestionBySlugUseCaseTests
    {
        private readonly InMemoryQuestionsRepository repository;
        private readonly GetQuestionBySlugUseCase sut;

        public GetQuestionBySlugUseCaseTests()
        {
            // Este código é executado antes de cada teste
            repository = new InMemoryQuestionsRepository();
            sut = new GetQuestionBySlugUseCase(repository);
        }

        [Fact]
        public async Task It_Should_Be_Able_To_Get_A_Question_By_Slug()
        {
            var createdQuestion = Question.Create("nova pergunta","novo conteúdo","1");

            await repository.create(createdQuestion);

            var question = await sut.Execute("nova-pergunta");

            Assert.Equal("novo conteúdo", question.Content);
            Assert.NotNull(question.Id);
            Assert.Single(repository.items);
            Assert.Equal("nova-pergunta", question.Slug.Value);
        }
    }
}
