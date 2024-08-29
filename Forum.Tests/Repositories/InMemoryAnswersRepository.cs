using Forum.Domain.Entities;
using Forum.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Forum.Tests.Repositories
{
    public class InMemoryAnswersRepository : IAnswerRepository
    {
        public List<Answer> items { get; set; } = new List<Answer>();

        public async Task create(Answer answer)
        {
            items.Add(answer);
        }

    }
}
