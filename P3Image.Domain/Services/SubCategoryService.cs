using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class SubCategoryService : BaseService<SubCategory>, ISubCategoryService
    {
        public ISubCategoryRepository _rep;
        private IFieldRepository _fieldRep;

        public SubCategoryService(ISubCategoryRepository rep, IFieldRepository fieldRep)
            : base(rep)
        {
            _rep = rep;
            _fieldRep = fieldRep;
        }

        public void RemoveField(Field field)
        {
            _fieldRep.Remove(field);
        }

        public Field AddField(Field field)
        {
            return  _fieldRep.Add(field);
        }
        public Field EditField(Field field)
        {
            return _fieldRep.Update(field);
        }

        public List<Field> GetFields(SubCategory subCategory)
        {
           return  _fieldRep.GetAll().Where(x => x.SubCategoryId == subCategory.Id).ToList();
        }

        public SubCategory GetBySlug(string slugCategory, string slugSubCategory)
        {
            var subCategory = _rep.Search(x => x.Category.Slug == slugCategory && x.Slug == slugSubCategory).FirstOrDefault();

            if (subCategory != null) 
                subCategory.Fields = subCategory.Fields.OrderBy(x => x.Order).ToList();

            return subCategory;
        }
    }
}