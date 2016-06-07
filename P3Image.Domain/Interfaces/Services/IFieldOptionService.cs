using P3Image.Domain.Entities;

namespace P3Image.Domain.Interfaces.Services
{
    public interface IFieldOptionService : IBaseService<FieldOption>
    {
        FieldOption Save(FieldOption fieldOption);
    }
}