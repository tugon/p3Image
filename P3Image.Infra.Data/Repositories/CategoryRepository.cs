﻿using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;

namespace P3Image.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
    }
}