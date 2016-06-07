using System.Collections.Generic;
using P3Image.Domain.Entities;

namespace P3Image.Domain.Interfaces.Services
{
    public interface ISubCategoryService : IBaseService<SubCategory>
    {
        void RemoveField(Field field);

        Field AddField(Field field);

        Field EditField(Field model);

        List<Field> GetFields(SubCategory subCategory);



        SubCategory GetBySlug(string slugCategory, string slugSubCategory);
    }
}