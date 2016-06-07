using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class FieldService : BaseService<Field>, IFieldService
    {
        private readonly IFieldRepository _rep;

        public FieldService(IFieldRepository rep)
            : base(rep)
        {
            _rep = rep;
        }

        public Field Save(Field fieldOption)
        {
            if (fieldOption.SubCategory != null)
                fieldOption.SubCategory = null;
            return fieldOption.Id > 0 ? _rep.Update(fieldOption) : _rep.Add(fieldOption);
        }
    }
}