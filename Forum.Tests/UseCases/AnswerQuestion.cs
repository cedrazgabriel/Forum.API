using Forum.Domain.Repositories;
using Forum.Domain.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using NSubstitute;

namespace Forum.Tests.UseCases;

public class AnswerQuestionUseCaseTests
{
   
    [Fact]
    public async Task It_Should_Be_Able_Create_A_Question()
    {
        string expectedContent = "Nova resposta";

        var fakeAnswerRepository = Substitute.For<IAnswerRepository>();

        var answerQuestion = new AnswerQuestion(fakeAnswerRepository);

        var answer = await answerQuestion.execute("1", "1", "Nova resposta");

        var actualContent = answer.Content;

        Assert.Equal(expectedContent, actualContent);
    }
}
