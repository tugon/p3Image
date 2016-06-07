using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class FieldService : BaseService<Field>, IFieldService
    {
        public IFieldRepository Rep;

        public FieldService(IFieldRepository rep)
            : base(rep)
        {
            Rep = rep;
        }
    }
}