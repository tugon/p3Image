using System.Collections.Generic;
using P3Image.App.Interfaces;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class SubCategoryApp : BaseApp<SubCategory>, ISubCategoryApp
    {
        private readonly ISubCategoryService _service;
        private readonly IFieldService _fieldService;
        private readonly IFieldOptionService _fieldOptionService;

        public SubCategoryApp(ISubCategoryService service, IFieldService fieldService, IFieldOptionService fieldOptionService)
            : base(service)
        {
            _service = service;
            _fieldService = fieldService;
            _fieldOptionService = fieldOptionService;
        }


        public SubCategory Save(SubCategory subCategory)
        {
            SubCategory result;
            subCategory.Category = null;
            
            if (subCategory.Id > 0)
            {
                SaveFields(subCategory);
                result = _service.Update(subCategory);

            }
            else
            {
                result = _service.Add(subCategory);
            }

            return result;
        }

        public Field AddField(Field model)
        {
            return _service.AddField(model);
        }

        public Field EditField(Field model)
        {
            return _service.EditField(model);
        }

        public void RemoveField(Field model)
        {
            _service.RemoveField(model);
        }

        private void SaveFields(SubCategory subCategory)
        {

            foreach (var field in subCategory.Fields)
            {
                SaveFieldOptions(field);
                _fieldService.Save(field);
            }
        }

        private void SaveFieldOptions(Field field)
        {
            foreach (var fieldOption in field.FieldOptions)
            {
                _fieldOptionService.Save(fieldOption);
            }
        }

        public List<Field> GetFields(SubCategory subCategory)
        {
            return _service.GetFields(subCategory);
        }

        public SubCategory GetBySlug(string slugCategory, string slugSubCategory)
        {
            return _service.GetBySlug(slugCategory, slugSubCategory);
        }
    }
}