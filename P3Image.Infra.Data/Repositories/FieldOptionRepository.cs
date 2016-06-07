using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Infra.Data.EF.Context;

namespace P3Image.Infra.Data.Repositories
{
    public class FieldOptionRepository : BaseRepository<FieldOption, P3ImageContext>, IFieldOptionRepository
    {
        public FieldOptionRepository(P3ImageContext db) : base(db)
        {
        }
    }
}