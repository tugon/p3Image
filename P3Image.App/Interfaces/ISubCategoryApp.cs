using System.Collections.Generic;
using P3Image.Domain.Entities;

namespace P3Image.App.Interfaces
{
    public interface ISubCategoryApp : IBaseApp<SubCategory>
    {
        SubCategory Save(SubCategory subCategory);
        Field AddField(Field model);
        Field EditField(Field model);
        void RemoveField(Field model);
        List<Field> GetFields(SubCategory model);
        SubCategory GetBySlug(string slugCategory, string slugSubCategory);
    }
}