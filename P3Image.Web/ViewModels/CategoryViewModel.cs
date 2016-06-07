using System.Collections.Generic;

namespace P3Image.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public virtual IList<SubCategoryViewModel> SubCategories { get; set; }
    }
}