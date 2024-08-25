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
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Forum.Tests.UseCases;

public class CreateQuestionUseCaseTests
{
    [Fact]
    public async Task It_Should_Be_Able_Create_A_Question()
    {
        var fakeQuestionRepository = Substitute.For<IQuestionRepository>();

        var sut = new CreateQuestionUseCase(fakeQuestionRepository);

        var question = await sut.Execute("1", "Novo título", "new-question");

        Assert.Equal("new-question", question.Content);
        Assert.NotNull(question.Id);
    }
}
