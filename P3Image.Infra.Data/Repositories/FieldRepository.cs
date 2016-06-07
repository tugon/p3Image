using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Infra.Data.EF.Context;

namespace P3Image.Infra.Data.Repositories
{
    public class FieldRepository : BaseRepository<Field, P3ImageContext>, IFieldRepository
    {
        public FieldRepository(P3ImageContext db) : base(db)
        {
        }
    }
}