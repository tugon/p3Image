using P3Image.App.Interfaces;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class SubCategoryApp : BaseApp<SubCategory>, ISubCategoryApp
    {
        private ISubCategoryService _service;

        public SubCategoryApp(ISubCategoryService service)
            : base(service)
        {
            _service = service;
        }
    }
}