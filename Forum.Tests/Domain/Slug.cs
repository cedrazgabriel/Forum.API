using Forum.Domain.Entities.ValueObjects;
using Forum.Domain.Repositories;
using Forum.Domain.UseCases;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Forum.Tests.Domain
{
    public class SlugTest
    {
        [Fact]
        public void It_Should_Be_Able_Create_A_New_Slug_From_Any_Text()
        {
            var slug = Slug.createFromText("Um TeXTO QualQuer");

            Assert.Equal("um-texto-qualquer", slug.Value);
        }
    }
}
