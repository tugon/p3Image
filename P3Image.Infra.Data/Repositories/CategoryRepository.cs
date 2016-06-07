using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Infra.Data.EF.Context;

namespace P3Image.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category,P3ImageContext>, ICategoryRepository
    {
        public CategoryRepository(P3ImageContext db) : base(db)
        {
        }
    }
}