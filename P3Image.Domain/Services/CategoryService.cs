using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Repositories;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Domain.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public ICategoryRepository Rep;

        public CategoryService(ICategoryRepository rep)
            : base(rep)
        {
            Rep = rep;
        }
    }
}