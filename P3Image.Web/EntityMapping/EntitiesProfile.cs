using AutoMapper;
using P3Image.Domain.Entities;
using P3Image.Domain.Enums;
using P3Image.Web.ViewModels;

namespace P3Image.Web.EntityMapping
{
    public class EntitiesProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                var prof = cfg.CreateProfile("EntitiesProfile");
                prof.CreateMap<Category, CategoryViewModel>();
                prof.CreateMap<SubCategory, SubCategoryViewModel>();
                prof.CreateMap<FieldOption, FieldOptionViewModel>();
                prof.CreateMap<Field, FieldViewModel>();
                prof.CreateMap<FieldType, ViewModels.Enums.FieldType>();

                prof.CreateMap<CategoryViewModel, Category>();
                prof.CreateMap<SubCategoryViewModel, SubCategory>();
                prof.CreateMap<FieldViewModel, Field>();
                prof.CreateMap<FieldOptionViewModel, FieldOption>();
                prof.CreateMap<ViewModels.Enums.FieldType, Domain.Enums.FieldType>();
            });
        }
    }
}