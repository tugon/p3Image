using P3Image.App.Interfaces;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class CategoryApp : BaseApp<Category>, ICategoryApp
    {
        private ICategoryService _service;

        public CategoryApp(ICategoryService service)
            : base(service)
        {
            _service = service;
        }
    }
}