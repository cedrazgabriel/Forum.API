﻿using Forum.Domain.Entities;

namespace Forum.Domain.Repositories;

public interface IQuestionRepository
{
    Task create(Question question);
    Task<Question?> findBySlug(string slug);
}
