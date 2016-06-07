using Ninject.Modules;
using P3Image.App;
using P3Image.App.Interfaces;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;
using P3Image.Domain.Services;
using P3Image.Infra.Data.Repositories;

namespace P3Image.Infra.IoC
{
    public class Module : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryService>();
            Bind<ISubCategoryService>().To<SubCategoryService>();
            Bind<IFieldService>().To<FieldService>();
            Bind<IFieldOptionService>().To<FieldOptionService>();

            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<ISubCategoryRepository>().To<SubCategoryRepository>();
            Bind<IFieldRepository>().To<FieldRepository>();
            Bind<IFieldOptionRepository>().To<FieldOptionRepository>();

            Bind<ICategoryApp>().To<CategoryApp>();
            Bind<ISubCategoryApp>().To<SubCategoryApp>();
            Bind<IFieldApp>().To<FieldApp>();
            Bind<IFieldOptionApp>().To<FieldOptionApp>();
        }
    }
}