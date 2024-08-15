using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Repositories
{
    public interface IAnswerRepository
    {
        Task create(Answer answer);
    }
}
