using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Infra.Data.EF.Context;

namespace P3Image.Infra.Data.Repositories
{
    public class SubCategoryRepository : BaseRepository<SubCategory, P3ImageContext>, ISubCategoryRepository
    {
        public SubCategoryRepository(P3ImageContext db) : base(db)
        {
        }
    }
}