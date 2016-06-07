using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class FieldOptionService : BaseService<FieldOption>, IFieldOptionService
    {
        private readonly IFieldOptionRepository _rep;

        public FieldOptionService(IFieldOptionRepository rep)
            : base(rep)
        {
            _rep = rep;
        }

        public FieldOption Save(FieldOption fieldOption)
        {
            if (fieldOption.Field != null)
                fieldOption.Field = null;
            return fieldOption.Id > 0 ? _rep.Update(fieldOption) : _rep.Add(fieldOption);
        }
    }
}